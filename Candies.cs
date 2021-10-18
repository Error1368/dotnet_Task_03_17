namespace Candies
{
    public abstract class BaseCandy
    {
        protected int weight_in_gramms, sugar_percentage;

        protected BaseCandy(int weight_in_gramms, int sugar_percentage)
        {
            this.weight_in_gramms = weight_in_gramms;
            this.sugar_percentage = sugar_percentage;
        }


        public int Weight_in_gramms
        {
            get { return weight_in_gramms; }
        }
        public int Sugar_percentage
        {
            get { return sugar_percentage; }
        }

    }

    public class ChocolateCandy : BaseCandy
    {
        public enum Chocolate_types
        {
            Dark,
            Milk,
            White //(Power)
        }
        protected Chocolate_types chocolate_type;
        protected bool has_nuts, has_caramel;
        public ChocolateCandy(int weight_in_gramms, int sugar_percentage, Chocolate_types chocolate_type, bool has_nuts, bool has_caramel) : base(weight_in_gramms, sugar_percentage)
        {
            this.chocolate_type = chocolate_type;
            this.has_nuts = has_nuts;
            this.has_caramel = has_caramel;
        }

        public Chocolate_types Chocolate_type
        {
            get { return chocolate_type; }
        }
        public bool Has_nuts
        {
            get { return has_nuts; }
        }

        public bool Has_caramel
        {
            get { return has_caramel; }
        }
    }

    public class AlcoholCandy : ChocolateCandy
    {
        protected int alc_grad;
        
        public AlcoholCandy(int weight_in_gramms, int sugar_percentage, Chocolate_types chocolate_type, int alc_grad) : base(weight_in_gramms, sugar_percentage, chocolate_type, false, false)
        {
            this.alc_grad = alc_grad;
        }

        public int Alc_grad
        {
            get { return alc_grad; }
        }
    }

    public class MarmaladeCandy : BaseCandy
    {
        protected string shell, jam;
        public MarmaladeCandy(int weight_in_gramms, int sugar_percentage, string shell, string jam) : base(weight_in_gramms, sugar_percentage)
        {
            this.shell = shell;
            this.jam = jam;
        }

        public MarmaladeCandy(int weight_in_gramms, int sugar_percentage, string shell) : this(weight_in_gramms, sugar_percentage, shell, "without")
        {
        }

        public string Shell
        {
            get { return shell; }
        }

        public string Jam
        {
            get { return jam; }
        }

    }
}
