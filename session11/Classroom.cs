class Classroom{
    public string classId;
    public string className;
    public List<Student> students;


    public Classroom(string classId, string className){
        this.classId = classId;
        this.className = className;
        this.students = new List<Student>();
    }

// phương thức thêm sinh viên vào lớp
    public void addStudent(Student student){
        students.Add(student);
        Console.WriteLine($"Student {student.studentName} added to class {className}");
    }

    public void showStudents(){
        Console.WriteLine($"\n ----Student in class {className}");
        foreach (Student student in students)
        {
            student.displayInfo();
        }
    }

    // phương thức tìm kiếm sinh viên theo mã sinh viên
    public void findStudentByStudentId(string studentId){
        //C1: dùng vòng lặp
        foreach (Student student in students){
            if(student.studentId == studentId){
                student.displayInfo();
                return;
            }
        }
        // trong trường hợp duyệt hết danh sách mà không có sinh viên nào
        Console.WriteLine($"Student with ID {studentId} not found in class {className}");
    }

}