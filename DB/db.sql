CREATE DATABASE SchoolManagement;
USE SchoolManagement;

CREATE TABLE Subjects (
    SubjectID INT PRIMARY KEY IDENTITY(1,1),
    SubjectName VARCHAR(50) NOT NULL UNIQUE
);

CREATE TABLE Teachers (
    TeacherID INT PRIMARY KEY IDENTITY(1,1),
    FullName VARCHAR(50) NOT NULL,
    SubjectID INT,
    Phone VARCHAR(20),
    HireDate DATE NOT NULL,
    FOREIGN KEY (SubjectID) REFERENCES Subjects(SubjectID)
);

CREATE TABLE Classes (
    ClassID INT PRIMARY KEY IDENTITY(1,1),
    ClassName VARCHAR(50) NOT NULL UNIQUE,
    TeacherID INT,
    FOREIGN KEY (TeacherID) REFERENCES Teachers(TeacherID)
);

CREATE TABLE Students (
    StudentID INT PRIMARY KEY IDENTITY(1,1),
    FullName VARCHAR(50) NOT NULL,
    DOB DATE NOT NULL,
    Gender VARCHAR(10) CHECK (Gender IN ('Male', 'Female', 'Other')),
    ClassID INT,
    Phone VARCHAR(20),
    FOREIGN KEY (ClassID) REFERENCES Classes(ClassID)
);

CREATE TABLE Enrollments (
    EnrollmentID INT PRIMARY KEY IDENTITY(1,1),
    StudentID INT NOT NULL,
    ClassID INT NOT NULL,
    EnrollmentDate DATE NOT NULL DEFAULT GETDATE(),
    FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
    FOREIGN KEY (ClassID) REFERENCES Classes(ClassID)
);

CREATE TABLE Attendance (
    AttendanceID INT PRIMARY KEY IDENTITY(1,1),
    StudentID INT NOT NULL,
    ClassID INT NOT NULL,
    Date DATE NOT NULL DEFAULT GETDATE(),
    Status VARCHAR(10) CHECK (Status IN ('Present', 'Absent', 'Late')),
    FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
    FOREIGN KEY (ClassID) REFERENCES Classes(ClassID)
);

CREATE TABLE Marks (
    MarkID INT PRIMARY KEY IDENTITY(1,1),
    StudentID INT NOT NULL,
    SubjectID INT NOT NULL,
    MarksObtained DECIMAL(5,2) CHECK (MarksObtained >= 0),
    ExamDate DATE NOT NULL,
    FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
    FOREIGN KEY (SubjectID) REFERENCES Subjects(SubjectID)
);

-- Triggers
-- Auto-assign students to 'Unassigned' if a class is deleted
CREATE TRIGGER MoveStudentsOnClassDelete
ON Classes
INSTEAD OF DELETE
AS
BEGIN
    DECLARE @UnassignedClassID INT;
    
    -- Check if 'Unassigned' class exists, else create it
    SELECT @UnassignedClassID = ClassID FROM Classes WHERE ClassName = 'Unassigned';

    IF @UnassignedClassID IS NULL
    BEGIN
        INSERT INTO Classes (ClassName) VALUES ('Unassigned');
        SET @UnassignedClassID = SCOPE_IDENTITY();
    END

    -- Move students to 'Unassigned' class
    UPDATE Students
    SET ClassID = @UnassignedClassID
    WHERE ClassID IN (SELECT ClassID FROM deleted);

    -- Delete the original class
    DELETE FROM Classes WHERE ClassID IN (SELECT ClassID FROM deleted);
END;

-- Ensure marks are only assigned for subjects students are studying
CREATE TRIGGER ValidateMarks
ON Marks
AFTER INSERT
AS
BEGIN
    IF EXISTS (
        SELECT 1 FROM inserted i
        LEFT JOIN Students s ON i.StudentID = s.StudentID
        LEFT JOIN Classes c ON s.ClassID = c.ClassID
        LEFT JOIN Teachers t ON c.TeacherID = t.TeacherID
        WHERE i.SubjectID <> t.SubjectID
    )
    BEGIN
        PRINT 'Error: Cannot assign marks for a subject the student is not studying.';
        ROLLBACK TRANSACTION;
    END
END;

-- Limit Enrollment
CREATE TRIGGER trg_LimitEnrollment
ON Students
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (
        SELECT ClassID 
        FROM Students
        GROUP BY ClassID
        HAVING COUNT(StudentID) > 100
    )
    BEGIN
        -- Rollback the transaction if limit exceeds
        RAISERROR ('Enrollment limit exceeded for this class. Maximum 100 students allowed.', 16, 1);
        ROLLBACK TRANSACTION;
    END
END;
