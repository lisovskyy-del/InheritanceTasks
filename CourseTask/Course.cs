namespace MainProgram.CourseTask;

class Course
{
    protected string Name { get; }
    protected string Duration { get; }

    public Course(string name, string duration)
    {
        this.Name = name;
        this.Duration = duration;
    }

    public override string ToString()
    {
        return $"Course name: {Name}\nCourse duration: {Duration}";
    }
}

class OnlineCourse : Course
{
    private string Platform { get; }

    public OnlineCourse(string name, string platform, string duration) : base(name, duration)
    {
        this.Platform = platform;
    }

    public override string ToString()
    {
        return $"Online course name: {Name}\nOnline course platform: {Platform}\nOnline course duration: {Duration}";
    }
}
