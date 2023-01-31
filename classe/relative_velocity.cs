namespace Projet_Nasa
{
    class Relative_velocity
    {
        private string kilometers_per_second;
        private string kilometers_per_hour;
        private string miles_per_hour;
        public Relative_velocity(string KmS, string KmH, string MH)
        {
            this.kilometers_per_second = KmS;
            this.kilometers_per_hour = KmH;
            this.miles_per_hour = MH;
        }
    }
}