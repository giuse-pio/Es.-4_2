namespace LibraryN4_2
{
    public class Quadrato
    {
        public double Lato { get; set; }

        public Quadrato() { }

        public Quadrato(double lato)
        {
            Lato = lato;
        }

        public override string ToString()
        {
            return string.Format("Q#{0}", Lato);
        }

        public static Quadrato operator +(Quadrato q1, Quadrato q2)
        {
            if (q1 == null || q2 == null)
            {
                throw new ArgumentNullException("Impossibile sommare quadrati nulli.");
            }

            double area1 = q1.Lato * q1.Lato;
            double area2 = q2.Lato * q2.Lato;
            double nuovaArea = area1 + area2;

            double nuovoLato = Math.Sqrt(nuovaArea);
            return new Quadrato(nuovoLato);
        }

        public static Quadrato operator -(Quadrato q1, Quadrato q2)
        {
            if (q1 == null || q2 == null)
            {
                throw new ArgumentNullException("Impossibile sottrarre quadrati nulli.");
            }
            double nuovoLato = Math.Abs(q1.Lato - q2.Lato);
            return new Quadrato(nuovoLato);
        }

        public static bool operator ==(Quadrato q1, Quadrato q2)
        {
            if (ReferenceEquals(q1, q2))
            {
                return true;
            }
            if (ReferenceEquals(q1, null) || ReferenceEquals(q2, null))
            {
                return false;
            }
            return q1.Lato == q2.Lato;
        }

        public static bool operator !=(Quadrato q1, Quadrato q2)
        {
            return !(q1 == q2);
        }

        public override bool Equals(object obj)
        {
            if (obj is Quadrato q)
            {
                return this == q;
            }
            return false;
        }


        public override int GetHashCode()
        {
            return Lato.GetHashCode();
        }


        public static Quadrato Parse(string s)
        {
            if (string.IsNullOrEmpty(s) || !s.StartsWith("Q#"))
            {
                throw new FormatException("La stringa non è una rappresentazione valida di un quadrato (deve iniziare con 'Q#').");
            }
            string stringa = s.Substring(2);
            try
            {
                double lato = double.Parse(stringa);
                return new Quadrato(lato);
            }
            catch (Exception ex)
            {
                throw new FormatException("Formato del valore del lato non valido.", ex);
            }
        }



    }
}
