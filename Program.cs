using System;

namespace Forex_Calculator
{
    // Custom class
    public class Lots
    { //Properties
        public double rPipValue;
        public double rPercentageRisk;
        public double rSLinPips;
        public double rAccountBalance;
        public double LotsTraded;

      //Constructors  
        public double calc()
        {    // Equation to work out Lots & send Lots back to program class   
            LotsTraded = rPercentageRisk / (rPipValue * rSLinPips);
            result = LotsTraded;
        }
    }

    private void btnCalculate_Click(object sender, RoutedEventArgs e)
    {
        // Assigning variables to input components
        double rAccountBalance = edtAccountBalance;
        double rPercentageRisk = edtPercentageRisk;
        double rPipValue;
        string sAccountCurrency = cmbAccCurrency;
        double rSLinPips = edtSlPips;
        String sAccounttype = cmbAccount;

        // Switch statement to get Account type
        switch (sAccounttype)
        {
            case "Standard Account": //Get variable value for final formula depending on the account balance
                rPipValue = 10;
                break;
            case "Mini Account":
                rPipValue = 1;
                break;
            case "Micro Account":
                rPipValue = 0.1;
                break;

            default:  // for if no account type was chosen show error message 
                MessageBox.Show("You Need to pick an Account Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                break;
        }
        // TO find out what account currency your are using
        switch (sAccountCurrency)
        {
            case "USD":
                sAccountCurrency = "USD";
                break;

            case "ZAR":
                sAccountCurrency = "ZAR";
                break;

            case "NZD":
                sAccountCurrency = "NZD";
                break;

            case "EUR":
                sAccountCurrency = "EUR";
                break;

            case "JPY":
                sAccountCurrency = "JPY";
                break;

            case "GBP":
                sAccountCurrency = "GBP";
                break;

            case "CHF":
                sAccountCurrency = "CHF";
                break;

            case "AUD":
                sAccountCurrency = "AUD";
                break;

            case "CAD":
                sAccountCurrency = "CAD";
                break;
        }

        // Instantiate/Send variables with value to class so the lots can be worked out
        Lots mylots = new Lots(LotsTraded);

        Lots.rPipValue = rPipValue;
        Lots.rPercentageRisk = rPercentageRisk;
        Lots.rSLinPips = rSLinPips;

        Double rLots = Lots.calc();
        rtbInformation.text = rLots;
    }

}
