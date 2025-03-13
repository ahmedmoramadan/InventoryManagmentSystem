using MaterialSkin;
using MaterialSkin.Controls;

namespace PresentationLayer
{
    public partial class StaffForm: MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public StaffForm()
        {
            InitializeComponent();
            // Apply Material Theme
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800, Primary.BlueGrey800, Primary.BlueGrey500,
                Accent.LightBlue700, TextShade.WHITE
            );
        }
    }
}
