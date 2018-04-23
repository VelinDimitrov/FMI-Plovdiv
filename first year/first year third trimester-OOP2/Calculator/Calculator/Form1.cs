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
        decimal memory = 0;

        string operationsDone = "";
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

            if (!isOperationDone)
            {
                if (currentNumber == "")
                {
                    return;
                }

                isOperationDone = true;

                //set left side  
                leftOperand = decimal.Parse(currentNumber);
                currentNumber = "";
                

                Button operationBtn = (Button)sender;
                string currentOperration = operationBtn.Text.Trim();
                operation = currentOperration;
            }

            

        }

        private void addingNums(object sender, EventArgs e)
        {
            Button numBtn = (Button)sender;
            string numToAdd = numBtn.Text.Trim();

            currentNumber += numToAdd;           

        }

        private void calculate(object sender, EventArgs e)
        {
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
                    case "*":
                        currentNumber = (leftOperand * rightOperand).ToString();
                        break;
                    case "/":
                        currentNumber = (leftOperand / rightOperand).ToString();
                        break;
                    case "%":
                        decimal percentage = (rightOperand / leftOperand) * 100;
                        currentNumber = (percentage).ToString();
                        break;
                }

                leftOperand = decimal.Parse(currentNumber);
                operationsDone = "";
                rightOperand = 0;
                operation = "";
            }
        }

        private void clearTextField(object sender, EventArgs e)
        {
            //C button
            operationsDone = "";
            currentNumber = "";
            operation = "";
            leftOperand = 0;
            rightOperand =0;
            isOperationDone = false;
        }

        private void deleteChar(object sender, EventArgs e)
        {
            //<-- button
            if (currentNumber!="")
            {
                currentNumber = currentNumber.Remove(currentNumber.Length - 1);
            }

        }

        private void memoryBtns(object sender, EventArgs e)
        {
            Button memoryBtn = (Button)sender;
            string pressedOperation = memoryBtn.Text.Trim();
            

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
                    break;
                case "M+":                    
                        memory += decimal.Parse(currentNumber);                    
                    break;
                case "M-":                    
                        memory -= decimal.Parse(currentNumber);                    
                    break;
            }
        }
    }
}
