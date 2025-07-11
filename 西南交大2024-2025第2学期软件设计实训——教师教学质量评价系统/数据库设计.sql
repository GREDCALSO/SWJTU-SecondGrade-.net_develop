-- 学生表
CREATE TABLE Student (
    keyID INT AUTO_INCREMENT PRIMARY KEY,
    Stu_No VARCHAR(20) NOT NULL UNIQUE,
    Name VARCHAR(50) NOT NULL,
    Major VARCHAR(100),
    is_deleted CHAR(1) DEFAULT '0' CHECK (is_deleted IN ('0', '1')),
    INDEX idx_stu_no (Stu_No),
    INDEX idx_stu_deleted (is_deleted)
) ENGINE=InnoDB;

-- 教师表
CREATE TABLE Teacher (
    keyID INT AUTO_INCREMENT PRIMARY KEY,
    Teacher_No VARCHAR(20) NOT NULL UNIQUE,
    Name VARCHAR(50) NOT NULL,
    College_No VARCHAR(20) NOT NULL,
    is_deleted CHAR(1) DEFAULT '0' CHECK (is_deleted IN ('0', '1')),
    INDEX idx_teacher_no (Teacher_No),
    INDEX idx_college_no (College_No),
    INDEX idx_teacher_deleted (is_deleted)
) ENGINE=InnoDB;

-- 课程表
CREATE TABLE Course (
    keyID INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Course_No VARCHAR(20) NOT NULL,
    Semester VARCHAR(20) NOT NULL,
    Teacher_No VARCHAR(20) NOT NULL,
    is_deleted CHAR(1) DEFAULT '0' CHECK (is_deleted IN ('0', '1')),
    INDEX idx_course_no (Course_No),
    INDEX idx_teacher_no (Teacher_No),
    INDEX idx_semester (Semester),
    INDEX idx_course_deleted (is_deleted),
    FOREIGN KEY (Teacher_No) REFERENCES Teacher(Teacher_No) ON UPDATE CASCADE
) ENGINE=InnoDB;

-- 选课表
CREATE TABLE Enrollment (
    keyID INT AUTO_INCREMENT PRIMARY KEY,
    Enroll_No VARCHAR(20) NOT NULL UNIQUE,
    Stu_No VARCHAR(20) NOT NULL,
    Course_No VARCHAR(20) NOT NULL,
    Grades DECIMAL(5,2),
    is_deleted CHAR(1) DEFAULT '0' CHECK (is_deleted IN ('0', '1')),
    INDEX idx_enroll_no (Enroll_No),
    INDEX idx_stu_no (Stu_No),
    INDEX idx_course_no (Course_No),
    INDEX idx_enroll_deleted (is_deleted),
    FOREIGN KEY (Stu_No) REFERENCES Student(Stu_No) ON UPDATE CASCADE,
    FOREIGN KEY (Course_No) REFERENCES Course(Course_No) ON UPDATE CASCADE
) ENGINE=InnoDB;

-- 督导组表
CREATE TABLE Mentor (
    keyID INT AUTO_INCREMENT PRIMARY KEY,
    Mentor_No VARCHAR(20) NOT NULL UNIQUE,
    Name VARCHAR(100) NOT NULL,
    is_deleted CHAR(1) DEFAULT '0' CHECK (is_deleted IN ('0', '1')),
    INDEX idx_mentor_no (Mentor_No),
    INDEX idx_mentor_deleted (is_deleted)
) ENGINE=InnoDB;

-- 学院管理员表
CREATE TABLE CollegeAdmin (
    keyID INT AUTO_INCREMENT PRIMARY KEY,
    admin_No VARCHAR(20) NOT NULL UNIQUE,
    College_No VARCHAR(20) NOT NULL UNIQUE,
    is_deleted CHAR(1) DEFAULT '0' CHECK (is_deleted IN ('0', '1')),
    INDEX idx_admin_no (admin_No),
    INDEX idx_college_no (College_No),
    INDEX idx_admin_deleted (is_deleted)
) ENGINE=InnoDB;

-- 用户表
CREATE TABLE User (
    keyID INT AUTO_INCREMENT PRIMARY KEY,
    UserName VARCHAR(50) NOT NULL UNIQUE,
    Password VARCHAR(255) NOT NULL,
    Chara_No VARCHAR(20) NOT NULL,
    is_deleted CHAR(1) DEFAULT '0' CHECK (is_deleted IN ('0', '1')),
    INDEX idx_username (UserName),
    INDEX idx_chara_no (Chara_No),
    INDEX idx_user_deleted (is_deleted)
) ENGINE=InnoDB;

-- 评价任务表
CREATE TABLE EvaluationAssignment (
    keyID INT AUTO_INCREMENT PRIMARY KEY,
    Chara_No VARCHAR(20) NOT NULL,
    Teacher_No VARCHAR(20) NOT NULL,
    StartTime DATETIME NOT NULL,
    EndTime DATETIME NOT NULL,
    is_completed CHAR(1) DEFAULT '0' CHECK (is_completed IN ('0', '1')),
    is_deleted CHAR(1) DEFAULT '0' CHECK (is_deleted IN ('0', '1')),
    INDEX idx_chara_no (Chara_No),
    INDEX idx_teacher_no (Teacher_No),
    INDEX idx_time_range (StartTime, EndTime),
    INDEX idx_assignment_deleted (is_deleted),
    FOREIGN KEY (Teacher_No) REFERENCES Teacher(Teacher_No) ON UPDATE CASCADE
) ENGINE=InnoDB;

-- 教师教学质量评价指标表
CREATE TABLE TeacherEvaluationIndex (
    keyID INT AUTO_INCREMENT PRIMARY KEY,
    Teacher_No VARCHAR(20) NOT NULL,
    Course_No VARCHAR(20) NOT NULL,
    Chara_No VARCHAR(20) NOT NULL,
    College_No VARCHAR(20) NOT NULL,
    EvalDate DATE NOT NULL,
     eval_TeachingDesign TINYINT UNSIGNED CHECK (eval_TeachingDesign BETWEEN 1 AND 5) COMMENT '教学设计评分(1-5分)',
    eval_Content TINYINT UNSIGNED CHECK (eval_Content BETWEEN 1 AND 5) COMMENT '教学内容评分(1-5分)',
    eval_ClassOrganzation TINYINT UNSIGNED CHECK (eval_ClassOrganzation BETWEEN 1 AND 5) COMMENT '课堂组织评分(1-5分)',
    eval_TeachingAttitude TINYINT UNSIGNED CHECK (eval_TeachingAttitude BETWEEN 1 AND 5) COMMENT '教学态度评分(1-5分)',
    eval_ProfessionQuality TINYINT UNSIGNED CHECK (eval_ProfessionQuality BETWEEN 1 AND 5) COMMENT '专业素质评分(1-5分)',
    eval_ResearchDepth TINYINT UNSIGNED CHECK (eval_ResearchDepth BETWEEN 1 AND 5) COMMENT '教研深度评分(1-5分)',
    eval_StuEffect TINYINT UNSIGNED CHECK (eval_StuEffect BETWEEN 1 AND 5) COMMENT '学生学习效果评分(1-5分)',
    eval_Comment TEXT COMMENT '评价语',
    is_deleted CHAR(1) DEFAULT '0' CHECK (is_deleted IN ('0', '1')),
    INDEX idx_teacher_no (Teacher_No),
    INDEX idx_course_no (Course_No),
    INDEX idx_chara_no (Chara_No),
    INDEX idx_college_no (College_No),
    INDEX idx_eval_date (EvalDate),
    INDEX idx_eval_deleted (is_deleted),
    FOREIGN KEY (Teacher_No) REFERENCES Teacher(Teacher_No) ON UPDATE CASCADE,
    FOREIGN KEY (Course_No) REFERENCES Course(Course_No) ON UPDATE CASCADE
) ENGINE=InnoDB;

-- 教师评价总分表
CREATE TABLE TeacherTotalPoints (
    keyID INT AUTO_INCREMENT PRIMARY KEY,
    Teacher_No VARCHAR(20) NOT NULL,
    Semester VARCHAR(20) NOT NULL,
    College_No VARCHAR(20) NOT NULL,
    TotalPoints DECIMAL(10,2) NOT NULL,
    is_deleted CHAR(1) DEFAULT '0' CHECK (is_deleted IN ('0', '1')),
    INDEX idx_teacher_no (Teacher_No),
    INDEX idx_semester (Semester),
    INDEX idx_college_no (College_No),
    INDEX idx_total_deleted (is_deleted),
    FOREIGN KEY (Teacher_No) REFERENCES Teacher(Teacher_No) ON UPDATE CASCADE,
    UNIQUE KEY uk_teacher_semester (Teacher_No, Semester)
) ENGINE=InnoDB;