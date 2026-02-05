using System.Reflection;
namespace AccessAndModify
{
    public class ModifyStatic
    {
        public static void ChangeCollegeName()
        {
            Type type = typeof(Student);

            FieldInfo field = type.GetField("collegeName", BindingFlags.NonPublic | BindingFlags.Static);

            field.SetValue(null, "Zeno University");
        }
    }
}