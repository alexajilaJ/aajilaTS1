namespace aajilaTS1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            int edad = Convert.ToInt32(txtEdad.Text);
            int salario = Convert.ToInt32(txtSalario.Text);
            double aporte = salario * 0.0945;

            DisplayAlert(" ", "Bienvenido " + nombre + " " + apellido + " \ntienes " + edad + " años" + " \ntu aporte mensual es " + aporte, "Cerrar");
        }

        /*private void ObtnCalcular_Clicked(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            int edad = Convert.ToInt32(txtEdad.Text);
            int salario = Convert.ToInt32(txtSalario);
            double aporte = salario * (9.45 / 100);
            DisplayAlert(" ","Bienvenido " + nombre + " "+ apellido +" \ntienes "+ edad + " años"+" \ntu aporte mensual es "+aporte, "Cerrar");
        }*/
    }

}
