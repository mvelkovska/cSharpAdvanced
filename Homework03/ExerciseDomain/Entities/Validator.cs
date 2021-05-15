
namespace ExerciseDomain.Entities
{
    public static class Validator
    {

        public static bool Validate(Vehicle v)
        {  
            if(v.Id > 0 && string.IsNullOrEmpty(v.Type)==false && v.YearOfProduction != 0)
            {
                return true;
            }

            return false;
        }
    }
}
