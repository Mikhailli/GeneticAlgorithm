using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace GeneticAlgorithm;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        MaximizeBox = false;
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
        CheckBoxEventHandling(CheckBox1);
        if (CheckBox1.Checked)
        {
            CountOfElementsTextBox.Text = @"3";
            LeftBorderTextBox.Text = @"-5.12";
            RightBorderTextBox.Text = @"5.12";
        }
    }

    private void checkBox2_CheckedChanged(object sender, EventArgs e)
    {
        CheckBoxEventHandling(CheckBox2);
        if (CheckBox2.Checked)
        {
            CountOfElementsTextBox.Text = @"2";
            LeftBorderTextBox.Text = @"-2.048";
            RightBorderTextBox.Text = @"2.048";
        }
    }
    
    private void checkBox3_CheckedChanged(object sender, EventArgs e)
    {
        CheckBoxEventHandling(CheckBox3);
        if (CheckBox3.Checked)
        {
            CountOfElementsTextBox.Text = @"5";
            LeftBorderTextBox.Text = @"-5.12";
            RightBorderTextBox.Text = @"5.12";
        }
    }

    private void CheckBox4_CheckedChanged(object sender, EventArgs e)
    {
        CheckBoxEventHandling(CheckBox4);
        if (CheckBox4.Checked)
        {
            CountOfElementsTextBox.Text = @"10";
            LeftBorderTextBox.Text = @"-600";
            RightBorderTextBox.Text = @"600";
        }
    }
    
    private void CheckBox5_CheckedChanged(object sender, EventArgs e)
    {
        CheckBoxEventHandling(CheckBox5);
        if (CheckBox5.Checked)
        {
            CountOfElementsTextBox.Text = @"10";
            LeftBorderTextBox.Text = @"-500";
            RightBorderTextBox.Text = @"500";
        }
    }

    private void NumberOfIndividsTextBox_TextChanged(object sender, EventArgs e)
    {
        PopulationError.Visible = !(int.TryParse(NumberOfIndividsTextBox.Text.Replace('.', ','), out _) 
                                    && Convert.ToInt32(NumberOfIndividsTextBox.Text.Replace('.', ',')) > 0);
            
        StartGeneticButton.Enabled = !HasErrors() && HasPickedFunction();
    }

    private void CrossoverRateTextBox_TextChanged(object sender, EventArgs e)
    {
        CrossoverRate.Visible = !(double.TryParse(CrossoverRateTextBox.Text.Replace('.', ','), out _) 
                                  && Convert.ToDouble(CrossoverRateTextBox.Text.Replace('.', ',')) > 0 
                                  && Convert.ToDouble(CrossoverRateTextBox.Text.Replace('.', ',')) < 1);
            
        StartGeneticButton.Enabled = !HasErrors() && HasPickedFunction();
    }

    private void MutateChanceTextBox_TextChanged(object sender, EventArgs e)
    {
        MutationChance.Visible = !(double.TryParse(MutateChanceTextBox.Text.Replace('.', ','), out _) 
                                   && Convert.ToDouble(MutateChanceTextBox.Text.Replace('.', ',')) > 0 
                                   && Convert.ToDouble(MutateChanceTextBox.Text.Replace('.', ',')) < 1);
            
        StartGeneticButton.Enabled = !HasErrors() && HasPickedFunction();
    }

    private void NumberOfLivesTextBox_TextChanged(object sender, EventArgs e)
    {
        NumberOfLives.Visible = !(int.TryParse(NumberOfLivesTextBox.Text.Replace('.', ','), out _)
                                  && Convert.ToInt32(NumberOfLivesTextBox.Text.Replace('.', ',')) > 0);
            
        StartGeneticButton.Enabled = !HasErrors() && HasPickedFunction();
    }

    private bool HasPickedFunction()
    {
        var collection = new List<CheckBox>();

        var functions = Controls.Find("FunctionsGroupBox", true);
        foreach (var component in functions[0].Controls)
        {
            if (component is CheckBox box)
            {
                collection.Add(box);
            }
        }

        return collection.Any(checkBox => checkBox.Checked);
    }

    private CheckBox GetCheckedCheckBox()
    {
        var collection = new List<CheckBox>();

        var functions = Controls.Find("FunctionsGroupBox", true);

        foreach (var component in functions[0].Controls)
        {
            if (component is CheckBox box)
            {
                collection.Add(box);
            }
        }
        
        return collection.FirstOrDefault(control => control is { Checked: true });
    }
    
    private CheckBox GetAnotherCheckedCheckBox(CheckBox currentCheckBox)
    {
        var collection = new List<CheckBox>();

        var functions = Controls.Find("FunctionsGroupBox", true);

        foreach (var component in functions[0].Controls)
        {
            if (component is CheckBox box)
            {
                collection.Add(box);
            }
        }
        
        return collection.FirstOrDefault(control => control is { Checked: true } && control.Name != currentCheckBox.Name);
    }
        
    private bool HasErrors()
    {
        var collection = new List<PictureBox>();

        var functions = Controls.Find("ChangeableParameters", true);
        foreach (var component in functions[0].Controls)
        {
            if (component is PictureBox box)
            {
                collection.Add(box);
            }
        }

        return collection.Any(pictureBox => pictureBox.Visible);
    }

    private void StartGeneticButton_Click(object sender, EventArgs e)
    {
        MinimumTextBox.Clear();
        
        var spaces = "          ";
        
        var genetic = new Genetic(Convert.ToInt32(NumberOfIndividsTextBox.Text), 
            Convert.ToDouble(CrossoverRateTextBox.Text.Replace('.', ',')), 30, 
            Convert.ToDouble(MutateChanceTextBox.Text.Replace('.', ',')),
            Convert.ToInt32(NumberOfLivesTextBox.Text), 
            Convert.ToDouble(LeftBorderTextBox.Text.Replace('.', ',')), 
            Convert.ToDouble(RightBorderTextBox.Text.Replace('.', ',')), 
            Convert.ToInt32(CountOfElementsTextBox.Text), SwitchCheckBoxToCalculateFunction());
        
        var coordinatesOfMinimum = genetic.StartGenetic();
        
        MinimumTextBox.AppendText("Минимум:" + spaces + genetic.Minimum.ToString(CultureInfo.InvariantCulture));
        MinimumTextBox.AppendText(Environment.NewLine);
        for(var i = 0; i <  coordinatesOfMinimum.Count; i++)
        {
            MinimumTextBox.AppendText($"X{i + 1}:");
            var length = i.ToString().Length;
            var difference = 6 - length;
            for (var j = 0; j < difference; j++)
            {
                MinimumTextBox.AppendText("   ");
            }
            MinimumTextBox.AppendText(spaces);
            MinimumTextBox.AppendText($"{coordinatesOfMinimum[i]}");
            MinimumTextBox.AppendText(Environment.NewLine);
        }
    }

    private Func<List<double>, double> SwitchCheckBoxToCalculateFunction()
    {
        var checkBox = GetCheckedCheckBox();
        if (checkBox.Name == "CheckBox1")
        {
            return FirstCalculateFunction;
        }
        if (checkBox.Name == "CheckBox2")
        {
            return SecondCalculateFunction;
        }
        if (checkBox.Name == "CheckBox3")
        {
            return ThirdCalculateFunction;
        }
        if (checkBox.Name == "CheckBox4")
        {
            return ForthCalculateFunction;
        }
        else
        {
            return FifthCalculateFunction;
        }
    }

    double FirstCalculateFunction(List<double> functionComponents)
    {
        return functionComponents.Sum(component => Math.Pow(component, 2));
    }
    
    double SecondCalculateFunction(List<double> functionComponents)
    {
        return 100 * Math.Pow(Math.Pow(functionComponents[0], 2) - Math.Pow(functionComponents[1], 2), 2)
            + Math.Pow(1 - functionComponents[0], 2);
    }
    
    double ThirdCalculateFunction(List<double> functionComponents)
    {
        return functionComponents.Sum(Math.Floor);
    }
    
    double ForthCalculateFunction(List<double> functionComponents)
    {
        var sum = 1d;
        var multiplication = 1d;
        for (var i = 0; i < functionComponents.Count; i++)
        {
            sum += Math.Pow(functionComponents[i], 2) / 4000;
            multiplication *= Math.Cos(functionComponents[i] / Math.Sqrt(i + 1));
        }

        return sum - multiplication;
    }
    
    double FifthCalculateFunction(List<double> functionComponents)
    {
        var sum = 0d;
        foreach (var component in functionComponents)
        {
            sum -= component * Math.Sin(Math.Sqrt(Math.Abs(component)));
        }

        return sum;
    }

    private void CheckBoxEventHandling(CheckBox checkBox)
    {
        if (checkBox.Checked)
        {
            var anotherCheckBox = GetAnotherCheckedCheckBox(checkBox);
            if (anotherCheckBox is not null)
            {
                anotherCheckBox.Checked = false;
            }
        }

        StartGeneticButton.Enabled = !HasErrors() && HasPickedFunction();
    }
}