namespace Application.DataObj.Module
{
    public class ModuleLessonsDataObj { }
    public class LessonInfoDataObj { }
    public class LessonContentDataObj { }
    public class UpdateLessonDataObj
    {
        required public String LessonId { get; set; }
        required public String? JwtToken { get; set; }
    }
    public class CompleteLessonDataObj
    {
        required public String LessonId { get; set; }
        required public String? JwtToken { get; set; }
    }
    public class ResetLessonDataObj
    {
        required public String LessonId { get; set; }
        required public String? JwtToken { get; set; }
    }
}
