namespace TSGUI.Shared.DataTypes
{
    public static class AgeGroup
    {
        //Uitgegaan van een employee die een age heeft en dan in een groep behoort
        public static string? GetAgeGroup(int age)
        {
            if (age < 0) return null;
            
            if (age <= 24)
                return "<25";
            if (age >= 25 && age <= 34)
                return "25-34";
            if (age >= 35 && age <= 44)
                return "35-44";
            if( age >= 45 && age <= 59)
                return "35-44";
            if( age >= 60)
                return "60+";

            return null;
        }   

            
    }
}
