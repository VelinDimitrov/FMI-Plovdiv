using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        //memory storing variable
        decimal memory = 0;
        // history of operations
        string operationsDone = "";
        //calculation variables
        string currentNumber = "";
        decimal leftOperand = 0;
        decimal rightOperand = 0;        
        string operation = "";
        bool isOperationDone = false;
        

        public Form1()
        {            
            InitializeComponent();
        }        

        private void numOperationBtns(object sender, EventArgs e)
        {
            //
            if (!isOperationDone)
            {
                if (currentNumber == "")
                {
                    return;
                }

                isOperationDone = true;

                //set leftOperand and visualize change  
                leftOperand = decimal.Parse(currentNumber);                
                currentNumber = "";
                visualizeResult();                                               
            }
            if (isOperationDone && currentNumber.Length!=0)
            {
                calculate(new object(), new EventArgs());
                currentNumber = "";
                isOperationDone = true;
                visualizeResult();
            }
            // set operation
                Button operationBtn = (Button)sender;
                string currentOperration = operationBtn.Text.Trim();
                operation = currentOperration;

            //visualize historyOfOperations
            operationsDone = $"{leftOperand} {operation}";
            visualizeOperationsHistory();

        }

        private void addingNums(object sender, EventArgs e)
        {
            Button numBtn = (Button)sender;
            string numToAdd = numBtn.Text.Trim();
            // checks whether currentNumber has precision sign
            if (currentNumber.Contains(".")&&numToAdd==".")
            {
                return;
            }
            currentNumber += numToAdd;
            visualizeResult();
        }

        private void calculate(object sender, EventArgs e)
        {
            //calculate if operation is chosen and rightOperand is entered
            if (isOperationDone && currentNumber!="")
            {
                rightOperand = decimal.Parse(currentNumber);
                switch (operation)
                {
                    case "+":
                        currentNumber = (leftOperand + rightOperand).ToString();
                        break;
                    case "-":
                        currentNumber = (leftOperand - rightOperand).ToString();
                        break;
                    case "X":
                        currentNumber = Math.Round(leftOperand * rightOperand,4).ToString();
                        break;
                    case "/":
                        currentNumber = Math.Round(leftOperand / rightOperand,4).ToString();
                        break;                    
                }
                // sets history and makes the calculator ready for another calculation
                operationsDone = $"{leftOperand} {operation} {rightOperand} ";
                leftOperand = decimal.Parse(currentNumber);                
                rightOperand = 0;
                operation = "";
                isOperationDone = false;
            }
            visualizeCalculatorTextBoxes();
        }

        private void clearTextField(object sender, EventArgs e)
        {
            //Clears all fields without memory
            //C button
            operationsDone = "";
            currentNumber = "";
            operation = "";
            leftOperand = 0;
            rightOperand =0;
            isOperationDone = false;
            //visualize changes
            visualizeCalculatorTextBoxes();
        }

        private void deleteChar(object sender, EventArgs e)
        {
            //<-- button
            //deletes last entered num
            if (currentNumber!="")
            {
                currentNumber = currentNumber.Remove(currentNumber.Length - 1);
            }
            visualizeResult();
        }

        private void memoryBtns(object sender, EventArgs e)
        {
            Button memoryBtn = (Button)sender;
            string pressedOperation = memoryBtn.Text.Trim();
            
            //select memory operation
            switch (pressedOperation)
            {
                case "MS":
                    if (currentNumber!="")
                    {
                        memory = decimal.Parse(currentNumber);
                    }
                    break;
                case "MC":
                    memory = 0;
                    break;
                case "MR":
                    if (memory!=0)
                    {
                        currentNumber = memory.ToString();
                    }
                    visualizeResult();
                    break;
                case "M+":                    
                        memory += decimal.Parse(currentNumber);                    
                    break;
                case "M-":                    
                        memory -= decimal.Parse(currentNumber);                    
                    break;
            }
            visualizeMemory();
        }

        private void visualizeOperationsHistory() {
           
            historyBox.Text = operationsDone;
        }
        private void visualizeResult()
        {
            resultBox.Text = currentNumber;
        }
        private void visualizeMemory()
        {
            if (memory!=0)
            {
                memoryBox.Text = memory.ToString();
            }
            else
            {
                memoryBox.Text = "";
            }
        }
        private void visualizeCalculatorTextBoxes()
        {
            // visualize Texts in the three TextBoxes
            visualizeResult();
            visualizeMemory();
            visualizeOperationsHistory();
        }

        private void percentBtn_Click(object sender, EventArgs e)
        {
            //calculate percentage operation
            if (isOperationDone)
            {
                decimal percentage =(decimal.Parse(currentNumber)/100)*leftOperand;
                currentNumber = Math.Round(percentage,4).ToString();
                visualizeResult();
            }
        }
    }
}
