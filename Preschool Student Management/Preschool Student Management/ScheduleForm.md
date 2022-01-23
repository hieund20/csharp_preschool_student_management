# Cách sử dụng

```cs
	using Preschool_Student_Management.Models;

	var scheduleForm = new ScheduleForm(Student.Query.Find("3"));
    scheduleForm.ShowDialog();
```

```cs
	using Preschool_Student_Management.Models;

	var scheduleForm = new ScheduleForm(Classroom.Query.Find("3"));
    scheduleForm.ShowDialog();
```