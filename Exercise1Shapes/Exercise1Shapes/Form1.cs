using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1Shapes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Instantiate the objects
        Cube myCube = new Cube();
        Sphere mySphere = new Sphere();
        Tetrahedron myTetrahedron = new Tetrahedron();
        
        // Display the default constructor
        private void Form1_Load(object sender, EventArgs e)
        {
            cubeSizeTextBox.Text = myCube.CurrentSize.ToString("F2");
            cubeSurfaceAreaLabel.Text = myCube.SurfaceArea.ToString("F2");
            cubeVolumeLabel.Text = myCube.Volume.ToString("F2");

            sphereSizeTextBox.Text = mySphere.CurrentSize.ToString("F2");
            sphereSurfaceAreaLabel.Text = mySphere.SurfaceArea.ToString("F2");
            sphereVolumeLabel.Text = mySphere.Volume.ToString("F2");


            tetraSizeTextBox.Text = myTetrahedron.CurrentSize.ToString("F2");
            tetraSurfaceAreaLabel.Text = myTetrahedron.SurfaceArea.ToString("F2");
            tetraVolumeLabel.Text = myTetrahedron.Volume.ToString("F2");


        }

        // Increase the size
        private void enlargeButton_Click(object sender, EventArgs e)
        {
            try
            {
            myCube.CurrentSize = (double.Parse(cubeSizeTextBox.Text));
            mySphere.CurrentSize = (double.Parse(sphereSizeTextBox.Text));
            myTetrahedron.CurrentSize = (double.Parse(tetraSizeTextBox.Text));
            myCube.Enlarge();
            mySphere.Enlarge();
            myTetrahedron.Enlarge();

            cubeSizeTextBox.Text = myCube.CurrentSize.ToString("F2");
            sphereSizeTextBox.Text = mySphere.CurrentSize.ToString("F2");
            tetraSizeTextBox.Text = myTetrahedron.CurrentSize.ToString("F2");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }

        // calculate the volume and surface area with new size
        private void createButton_Click(object sender, EventArgs e)
        {
            try
            {
                myCube.CurrentSize = (double.Parse(cubeSizeTextBox.Text));
                cubeSurfaceAreaLabel.Text = myCube.SurfaceArea.ToString("F2");
                cubeVolumeLabel.Text = myCube.Volume.ToString("F2");

                mySphere.CurrentSize = (double.Parse(sphereSizeTextBox.Text));
                sphereSurfaceAreaLabel.Text = mySphere.SurfaceArea.ToString("F2");
                sphereVolumeLabel.Text = mySphere.Volume.ToString("F2");

                myTetrahedron.CurrentSize = (double.Parse(tetraSizeTextBox.Text));
                tetraSurfaceAreaLabel.Text = myTetrahedron.SurfaceArea.ToString("F2");
                tetraVolumeLabel.Text = myTetrahedron.Volume.ToString("F2");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // try negative size.
        private void negativeButton_Click(object sender, EventArgs e)
        {
            try
            {
                myCube.CurrentSize = (double.Parse(cubeSizeTextBox.Text));
                mySphere.CurrentSize = (double.Parse(sphereSizeTextBox.Text));
                myTetrahedron.CurrentSize= (double.Parse(tetraSizeTextBox.Text));



            }
            catch (Exception ex)
            {
                cubeSurfaceAreaLabel.Text = "";
                cubeVolumeLabel.Text = "";
                sphereSurfaceAreaLabel.Text = "";
                sphereVolumeLabel.Text = "";
                tetraSurfaceAreaLabel.Text = "";
                tetraVolumeLabel.Text = "";
                MessageBox.Show(ex.Message);
            }

        }
    }
}
