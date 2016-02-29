﻿using Eto.Forms;
using Eto.Serialization.Xaml;
using Pulsar4X.ViewModel;
using System;
using System.Linq;

namespace Pulsar4X.CrossPlatformUI.Views.ComponentTemplateDesigner
{
    public class ComponentTemplateAbilityPropertiesView : Panel
    {
        protected ComboBox GuiHint { get; set; }
        protected StackLayout GuiHintControls { get; set; }

        protected TextBox NameTBx { get; set; }
        protected TextBox DescriptionTBx { get; set; }
        protected TextBox AbilityFormulaTBx { get; set; }
        

        private ComponentAbilityTemplateVM _viewModel;

        public ComponentTemplateAbilityPropertiesView()
        {
            XamlReader.Load(this);
            GuiHint.BindDataContext(c => c.DataStore, (DictionaryVM<Guid, string, string> m) => m.DisplayList);
            GuiHint.SelectedIndexBinding.BindDataContext((DictionaryVM<Guid, string, string> m) => m.SelectedIndex);

            NameTBx.GotFocus += (sender, e) => ((ComponentTemplateDesignerBaseVM)DataContext).SubControlInFocus = FocusedControl.NameControl;
            DescriptionTBx.GotFocus += (sender, e) => ((ComponentTemplateDesignerBaseVM)DataContext).SubControlInFocus = FocusedControl.DescriptionControl;
            AbilityFormulaTBx.GotFocus += (sender, e) => ((ComponentTemplateDesignerBaseVM)DataContext).SubControlInFocus = FocusedControl.AbilityFormulaControl;
        }

        public ComponentTemplateAbilityPropertiesView(ComponentAbilityTemplateVM viewModel) : this()
        {
            _viewModel = viewModel;
            DataContext = viewModel;

            _viewModel.SelectedGuiHint.PropertyChanged += GuiHint_SelectedIndexChanged;
            GuiHint_SelectedIndexChanged(this, null);
        }

        private void GuiHint_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (_viewModel.SelectedGuiHint.GetKey())
            {
                case ECSLib.GuiHint.GuiSelectionMaxMin:
                    GuiHintMinMax();
                    break;
                case ECSLib.GuiHint.GuiTechSelectionList:
                    GuiTechSelectionList();
                    break;
                case ECSLib.GuiHint.GuiTextDisplay:
                    GuiHintTextDisplay();
                    break;
                case ECSLib.GuiHint.None:
                    GuiHintNone();
                    break;

            }
        }

        private void GuiHintMinMax()
        {
            GuiHintControls.Items.Clear();

            TableLayout tl1 = new TableLayout(2, 2);

            Label lblMin = new Label();
            lblMin.Text = "MinFormula";
            TextBox minFormula = new TextBox();
            minFormula.TextBinding.BindDataContext((ComponentAbilityTemplateVM n) => n.MinFormula);
            minFormula.GotFocus += (sender, e) => ((ComponentTemplateDesignerBaseVM)DataContext).SubControlInFocus = FocusedControl.MinControl;
            minFormula.DataContext = _viewModel;
            
            Label lblMax = new Label();
            lblMax.Text = "MaxFormula:";
            TextBox maxFormula = new TextBox();
            maxFormula.TextBinding.BindDataContext((ComponentAbilityTemplateVM n) => n.MaxFormula);
            maxFormula.GotFocus += (sender, e) => ((ComponentTemplateDesignerBaseVM)DataContext).SubControlInFocus = FocusedControl.MaxControl;
            maxFormula.DataContext = _viewModel;

            tl1.Add(lblMin, 0, 0);
            tl1.Add(minFormula, 1, 0);
            tl1.Add(lblMax, 0, 1);
            tl1.Add(maxFormula, 1, 1);
            GuiHintControls.Items.Add(tl1);
            
            
        }

        private void GuiTechSelectionList()
        {
            GuiHintControls.Items.Clear();
            
            TechList techList = new TechList();
            techList.DataContext = _viewModel.GuidDict;
            GuiHintControls.Items.Add(techList);

        }

        private void GuiHintTextDisplay()
        {
            //this just uses the exsisting Abilityformula
            GuiHintControls.Items.Clear();
            Label label = new Label();
            label.Text = "Displays AbilityFormula";
            GuiHintControls.Items.Add(label);
        }

        private void GuiHintNone()
        {
            GuiHintControls.Items.Clear();
            Label label = new Label();
            label.Text = "Does Not display anything, however, \r\nAbilityFormula still works 'under the hood'";
            GuiHintControls.Items.Add(label);

        }
    }
}