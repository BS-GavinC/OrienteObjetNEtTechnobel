public class Compte
{
    private double Solde { get; set; }

    public double this[string money]
    {
        get
        {
            switch (money)
            {
                case "EUR":
                    return Solde;
                    break;
                case "USD":
                    return Solde * 1.21;
                    break;
                case "CHF":
                    return Solde * 0.98;

                default:
                    return 0;
                    break;
            }
        }
        set
        {
            switch (money)
            {
                case "EUR":
                    Solde = value;
                    break;
                case "USD":
                    Solde = value * 0.79;
                    break;
                case "CHF":
                    Solde = value * 1.04;
                    break;
                default:
                    break;
            }
        }
    }
}