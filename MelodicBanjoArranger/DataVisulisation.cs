
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Msagl.GraphViewerGdi;
using System.Linq;
using Microsoft.Msagl.Drawing;

namespace MelodicBanjoArranger
{
    public static class DataVisulisation
    {
        public static GViewer GViewerewer { get; private set; }

        public static void Create_Graph(List<note_node> DTArray)
        {


            int index;


            //String Temp_str = null;
            System.Windows.Forms.Form GDIForm = new System.Windows.Forms.Form();
            GDIForm.Size = new System.Drawing.Size(1000, 1000);
            //GDIForm.WindowState = FormWindowState.Maximized;

            //create a viewer object
            GViewerewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();

            //create a graph object
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");

            //Sort DT Awway by position
            List<note_node> sorted_list = DTArray.OrderBy(o => o.NoteDetails.position).ToList();



            foreach (note_node temp_node in sorted_list)
            {
                index = DTArray.IndexOf(temp_node);
                String Parent_Note;
                String Current_Note;


                // Check if it's a route node 
                if (temp_node.parent_node == null)
                {
                    // Route node so skip
                    Current_Note = temp_node.ToStringSmall() + " Index" + temp_node.tree_index;
                    Node graph_node = new Node(Current_Note);
                    Microsoft.Msagl.Drawing.Color tempcolor = new Microsoft.Msagl.Drawing.Color();
                    graph_node.Attr.FillColor = Color.AliceBlue;
                    graph_node.Attr.Shape = Shape.Diamond;
                    graph.AddNode(graph_node);
                }
                else
                {
                    //Build the Node string values
                    //Parent_Note = temp_node.parent_node_index.GetValueOrDefault().ToString() + "\r\n" + DTArray[temp_node.parent_node_index.GetValueOrDefault()].ToStringSmall();
                    ///Current_Note = DTArray.IndexOf(temp_node).ToString() + "\r\n" + temp_node.ToStringSmall();

                    Parent_Note = temp_node.parent_node.ToStringSmall() + " Index" + temp_node.parent_node.tree_index;
                    Current_Note = temp_node.ToStringSmall() + " Index" + temp_node.tree_index;

                    //Current_Note = temp_node.ToStringSmall();

                    // 255,0,0 = Red
                    // 0,255,0 = Green

                    // Not route node so add edge details
                 
                        graph.AddEdge(Parent_Note, temp_node.cost.ToString(), Current_Note);

                    //graph.AddNode()

                    //Microsoft.Msagl.Drawing.Color tempcol = Microsoft.Msagl.Drawing.Color.
                    //    FromArgb(255,255,255);

                    if (temp_node.Excluded)
                    {
                        graph.FindNode(Current_Note).Attr.FillColor = Color.Red;
                    }
                }
            }

            //bind the graph to the viewer
            GViewerewer.Graph = graph;

            //GViewerewer.Size = new System.Drawing.Size(800, 800);

            //associate the viewer with the GDIForm
            GDIForm.SuspendLayout();
            GViewerewer.Dock = System.Windows.Forms.DockStyle.Fill;
            GDIForm.Controls.Add(GViewerewer);
            GDIForm.ResumeLayout();

            //show the GDIForm
            GDIForm.Show();
        }

    }
}

