namespace IceTask4_PROG6221_Calculator
{
    public partial class Form1 : Form
    {

        // Define delegate for event handler
        public delegate void OperationPerformedEventHandler(string operation, double result);

        // Define event based on delegate
        public event OperationPerformedEventHandler OperationPerformed;


        public Form1()
        {
            InitializeComponent();
        }


        private void PerformOperation(Action<double, double> operation, string operationName)
        {
            double num1, num2;
            if (double.TryParse(txtbox_num1.Text, out num1) && double.TryParse(txtbox_num2.Text, out num2))
            {
                operation(num1, num2);
            }
            else
            {
                lbl_ans.Text = "Invalid input!";
            }
        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            PerformOperation((a, b) =>
            {
                double result = a + b;
                // Raise event when addition is performed
                OperationPerformed?.Invoke("Addition", result);
                lbl_ans.Text = $"Result: {a} + {b} = {result}";
            }, "+");
        }

        private void btn_subtract_Click(object sender, EventArgs e)
        {
            PerformOperation((a, b) =>
            {
                double result = a - b;
                // Raise event when subtraction is performed
                OperationPerformed?.Invoke("Subtraction", result);
                lbl_ans.Text = $"Result: {a} - {b} = {result}";
            }, "-");
        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
            PerformOperation((a, b) =>
            {
                double result = a * b;
                // Raise event when multiplication is performed
                OperationPerformed?.Invoke("Multiplication", result);
                lbl_ans.Text = $"Result: {a} * {b} = {result}";
            }, "x");
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            PerformOperation((a, b) =>
            {
                if (b == 0)
                {
                    lbl_ans.Text = "Cannot divide by zero!";
                }
                else
                {
                    double result = a / b;
                    // Raise event when division is performed
                    OperationPerformed?.Invoke("Division", result);
                    lbl_ans.Text = $"Result: {a} / {b} = {result}";
                }
            }, "/");
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            // Clear text boxes and result label
            txtbox_num1.Text = "";
            txtbox_num2.Text = "";
            lbl_ans.Text = "Result:";
        }
    }
}
