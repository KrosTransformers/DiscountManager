using System.Windows.Forms;

namespace DiscountManagerApp
{
    public partial class DiscountManagerView : Form
    {
        private DiscountManagerViewModel _viewModel;
        public DiscountManagerView(DiscountManagerViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            BindControls();
        }

        private void BindControls()
        {
            numAmount.DataBindings.Add(nameof(numAmount.Value),
                _viewModel,
                nameof(_viewModel.Amount),
                true,
                DataSourceUpdateMode.OnPropertyChanged);
            numYears.DataBindings.Add(nameof(numYears.Value), _viewModel, nameof(_viewModel.Years), true, DataSourceUpdateMode.OnPropertyChanged);
            cmbType.DataBindings.Add(nameof(cmbType.SelectedValue), _viewModel, nameof(_viewModel.Type), true, DataSourceUpdateMode.OnPropertyChanged);
            lblCalculatedValue.DataBindings.Add(nameof(lblCalculatedValue.Text), _viewModel, nameof(_viewModel.Discount), true, DataSourceUpdateMode.OnPropertyChanged);
            cmbType.DataSource = _viewModel.Types;
            cmbType.ValueMember = "item2";
            cmbType.DisplayMember = "item1";
        }
    }
}
