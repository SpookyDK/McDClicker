using Microsoft.Maui.Platform;

namespace McDClicker;

public partial class MainPage : ContentPage
{

    double Nugget = 100000;
    double NuggetsPerClick = 1;
    double Arbejdere = 0;
    double Gryder = 0;
    double Grill = 0;
    double Manager = 0;
    double Nuggetsbuys = 0;
    double Bestillings = 0;
    double Resturanter = 0;

    double ArbejderePris = 50;
    double GryderPris = 500;
    double GrillPris = 2000;
    double ManagerPris = 50000;
    double NuggetsbuysPris = 100000;
    double BestillingsPris = 500000;
    double ResturanterPris = 10000000;


    public MainPage()
	{
		InitializeComponent();
	}

	private void NuggetKnap_Clicked(object sender, EventArgs e)
	{
		Nugget += NuggetsPerClick;
		NuggetDisplay.Text = Nugget.ToString("N0");
        NuggetKnap.ScaleX = 0.9;
        NuggetKnap.ScaleY = 0.9;
    }
    private void NuggetKnap_Released(object sender, EventArgs e)
    {
        NuggetKnap.ScaleX = 1;
        NuggetKnap.ScaleY = 1;
    }



    private void Arbejder_Clicked(object sender, EventArgs e)
	{
        
        if (Nugget >= ArbejderePris)
		{
			NuggetsPerClick += 1;
			Arbejdere += 1; ;
			Nugget -= ArbejderePris;
            NuggetDisplay.Text = Nugget.ToString("N0");
            NPCTEXT.Text = (NuggetsPerClick.ToString() + " NPC");
            ArbejderePris =  ArbejderePris * 1.1;
            ArbejderAntal.Text = Arbejdere.ToString();
            ArbejderPrisKnap.Text = ArbejderePris.ToString("0") + " pr stk";
        }
	}

	private void FritureGrydeKnap_Clicked(object sender, EventArgs e)
	{
        if (Nugget >= GryderPris) 
        {
            NuggetsPerClick += 2;
            Gryder += 1; ;
            Nugget -= GryderPris;
            NuggetDisplay.Text = Nugget.ToString("N0");
            NPCTEXT.Text = (NuggetsPerClick.ToString() + " NPC");
            GryderPris = GryderPris * 1.1;
            GrydeAntal.Text = Gryder.ToString();
            GrydePrisKnap.Text = GryderPris.ToString("0") + " pr stk";
        }
    }

	private void GrillKnap_Clicked(object sender, EventArgs e)
	{
        if (Nugget >= GrillPris)
        {
            NuggetsPerClick += 5;
            Grill += 1; 
            Nugget -= GrillPris;
            NuggetDisplay.Text = Nugget.ToString("N0");
            NPCTEXT.Text = (NuggetsPerClick.ToString() + " NPC");
            GrillPris = GrillPris * 1.1;
            GrillAntal.Text = Grill.ToString();
            GrillPrisKnap.Text = GrillPris.ToString("0") + " pr stk";
        }
    }

	private void ManagerKnap_Clicked(object sender, EventArgs e)
	{
        if (Nugget >= ManagerPris)
        {
            NuggetsPerClick += 10;
            Manager += 1; ;
            Nugget -= ManagerPris;
            NuggetDisplay.Text = Nugget.ToString("N0");
            NPCTEXT.Text = (NuggetsPerClick.ToString() + " NPC");
            ManagerPris = ManagerPris * 1.1;
            ManagerAntal.Text = Manager.ToString();
            ManagerPrisKnap.Text = ManagerPris.ToString("0") + " pr stk";
        }
    }

	private void NuggetBuyKnap_Clicked(object sender, EventArgs e)
	{
        if (Nugget >= NuggetsbuysPris)
        {
            NuggetsPerClick += 20;
            Nuggetsbuys += 1; ;
            Nugget -= NuggetsbuysPris;
            NuggetDisplay.Text = Nugget.ToString("N0");
            NPCTEXT.Text = (NuggetsPerClick.ToString() + " NPC");
            NuggetsbuysPris = NuggetsbuysPris * 1.1;
            NuggetAntal.Text = Nuggetsbuys.ToString();
            NuggetPrisKnap.Text = NuggetsbuysPris.ToString("0") + " pr stk";
        }
    }

	private void BestillingsKnap_Clicked(object sender, EventArgs e)
	{
        if (Nugget >= BestillingsPris)
        {
            NuggetsPerClick += 50;
            Bestillings += 1; ;
            Nugget -= BestillingsPris;
            NuggetDisplay.Text = Nugget.ToString("N0");
            NPCTEXT.Text = (NuggetsPerClick.ToString() + " NPC");
            BestillingsPris = BestillingsPris * 1.1;
            BestillingsAntal.Text = Bestillings.ToString();
            BestillingsPrisKnap.Text = BestillingsPris.ToString("0") + " pr stk";
        }
    }

	private void Resturant_Clicked(object sender, EventArgs e)
	{
        if (Nugget >= ResturanterPris)
        {
            NuggetsPerClick += 2000;
            Resturanter += 1; ;
            Nugget -= ResturanterPris;
            NuggetDisplay.Text = Nugget.ToString("N0");
            NPCTEXT.Text = (NuggetsPerClick.ToString() + " NPC");
            ResturanterPris = ResturanterPris * 1.1;
            ResturantAntal.Text = Resturanter.ToString();
            ResturantPrisKnap.Text = ResturanterPris.ToString("0") + " pr stk";

        }
    }

    

    
}


