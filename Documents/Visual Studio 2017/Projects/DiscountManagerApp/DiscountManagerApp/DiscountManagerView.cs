using System.Windows.Forms;

namespace DiscountManagerApp
{
    public partial class DiscountManagerView : Form
    {
        private IDiscountManagerViewModel _viewModel;

        public DiscountManagerView(IDiscountManagerViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            BindControls();
        }

        private void BindControls()
        {
            numPrice.DataBindings.Add(nameof(numPrice.Value),
                _viewModel,
                nameof(_viewModel.Price),
                true,
                DataSourceUpdateMode.OnPropertyChanged);

            numYears.DataBindings.Add(nameof(numYears.Value),
                _viewModel,
                nameof(_viewModel.Years),
                true,
                DataSourceUpdateMode.OnPropertyChanged);

            numYears.DataBindings.Add("Enabled", _viewModel, "ZobrazMa", true, DataSourceUpdateMode.OnPropertyChanged);

            cmbType.DataBindings.Add(nameof(cmbType.SelectedValue),
                _viewModel,
                nameof(_viewModel.Type),
                true,
                DataSourceUpdateMode.OnPropertyChanged);

            lblCalculatedValue.DataBindings.Add(nameof(lblCalculatedValue.Text),
                _viewModel,
                nameof(_viewModel.Discount),
                true,
                DataSourceUpdateMode.OnPropertyChanged);

            cmbType.DataSource = _viewModel.Types;
            cmbType.ValueMember = "item2";
            cmbType.DisplayMember = "item1";
        }

        private void numPrice_ValueChanged(object sender, System.EventArgs e)
        {
          //  _viewModel.Price = numPrice.Value;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            _viewModel.Save();
        }
    }
}
