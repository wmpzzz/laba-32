namespace laba_32
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        private void CalculateButton_click(object sender, EventArgs e)
        {
            

            try
            {
                decimal number1 = Convert.ToDecimal(DividendTextBox.Text);
                decimal number2 = Convert.ToDecimal(DividerTextBox.Text);
                decimal division = number1 / number2;
                ResultLabel.Text = "���������: " + division.ToString();

            }
            catch (DivideByZeroException)
            {
                ResultLabel.Text = "������ �� 0 ������!!!!!!";
            }
            catch (FormatException)
            {
                ResultLabel.Text = "�� ���� ������������ ������!!!!!!!!!";
            }

            
        }
    }
}
