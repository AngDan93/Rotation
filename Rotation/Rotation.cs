using System;
using System.Windows.Forms;

using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;

using static System.Math;
using static System.Convert;

/// <summary>
/// Preconditions:
///1.Open an assembly with at least a component.
///2. Run the program.
///3. Select a component.
///4. Change it the angles.
///
///Postconditions:
///1.Look the component rotated
/// </summary>
/// 

namespace Rotation
{
    public partial class Rotation : Form
    {

        public Rotation()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            swApp = new SldWorks();
            if (swModel == null)
            {
                swModel = (ModelDoc2)swApp.ActiveDoc;

            }
        }
        /// <summary>
        /// Allows to rotate XYZ axis a component in an assembly 
        /// </summary>
        private void rotate()
        {


            double A = ToDouble(axisX.Value) * PI / 180;
            double B = ToDouble(axisY.Value) * PI / 180;
            double C = ToDouble(axisZ.Value) * PI / 180;


            //Rotate in XYZ
            double[] m = new double[9]
            {
                Cos(B)*Cos(C) , -Cos(A)*Sin(C) + Sin(A)*Sin(B)*Cos(C) , Sin(A)*Sin(C) + Cos(A)*Sin(B)*Cos(C),
                Cos(B)*Sin(C) ,  Cos(A)*Cos(C) + Sin(A)*Sin(B)*Sin(C) ,-Sin(A)*Cos(C) + Cos(A)*Sin(B)*Sin(C),
                -Sin(B)       ,  Sin(A)*Cos(B)                        , Cos(A)*Cos(B)
            };


            ////Only Rotate in X
            //double angle = ToDouble(axisX.Value) * PI / 180;
            //double[] m = new double[9]
            //{
            //    1, 0         , 0,
            //    0, Cos(angle), -Sin(angle),
            //    0, Sin(angle), Cos(angle)
            //};

            ////Only Rotate in Y
            //double angle = ToDouble(axisY.Value) * PI / 180;
            //double[] m = new double[9]
            //{
            //    Cos(angle) , 0, Sin(angle),
            //    0          , 1, 0,
            //    -Sin(angle), 0, Cos(angle)
            //};

            ////Only Rotate in Z
            //double angle = ToDouble(axisZ.Value) * PI / 180;
            //double[] m = new double[9]
            //{
            //    Cos(angle),-Sin(angle), 0,
            //    Sin(angle), Cos(angle), 0,
            //    0         , 0         , 1
            //};


            try
            {

                if (swApp != null)
                {

                    if (swModel != null)
                    {
                        if (swModel.GetType() == (int)swDocumentTypes_e.swDocASSEMBLY)
                        {
                            if (myComp == null)
                            {
                                selectComp();
                            }

                            if (myComp != null)
                            {
                                object XformIn = new double[16]
                                {
                                        m[0],  m[1],  m[2],
                                        m[3],  m[4],  m[5],
                                        m[6],  m[7],  m[8],
                                        0   ,  0   ,  0   ,
                                        1   ,  0   ,  0   ,
                                        0.0
                                };
                                MathUtility swMathUtility = (MathUtility)swApp.GetMathUtility();
                                MathTransform transform = (MathTransform)swMathUtility.CreateTransform(XformIn);
                                bool sts = myComp.SetTransformAndSolve2(transform);
                                if (sts)
                                    swModel.EditRebuild3();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please, open an assembly", "Component selector", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }
        /// <summary>
        /// Allows select a componet in an assembly
        /// </summary>
        private void selectComp()
        {
            SelectionMgr selMgr = (SelectionMgr)swModel.SelectionManager;
            MessageBox.Show("Please, select a component", "Component selector", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            if (selMgr.GetSelectedObjectCount2(Mark: -1) != 0)
            {
                if (selMgr.GetSelectedObjectType3(1, -1) == (int)swSelectType_e.swSelCOMPONENTS)
                {
                    myComp = selMgr.GetSelectedObject6(1, -1);
                }
                else
                {
                    if (selMgr.GetSelectedObjectType3(1, -1) == (int)swSelectType_e.swSelFACES)
                    {
                        Entity swEnt = (Entity)selMgr.GetSelectedObject6(1, -1);
                        myComp = (Component2)swEnt.GetComponent();
                    }
                    else
                    {
                        MessageBox.Show("No selected component");
                    }
                }
            }
            else
            {
                MessageBox.Show("No selected component");
            }
        }

        private void axisX_ValueChanged(object sender, EventArgs e)
        {
            rotate();
        }

        private void axisY_ValueChanged(object sender, EventArgs e)
        {
            rotate();
        }

        private void axisZ_ValueChanged(object sender, EventArgs e)
        {
            rotate();
        }


        /// <summary>
        /// 
        /// </summary>
        public SldWorks swApp;
        public ModelDoc2 swModel;
        Component2 myComp;
    }

}
