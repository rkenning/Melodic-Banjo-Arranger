
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualStudio.GraphModel;

namespace MelodicBanjoArranger
{
    public static class DataVisulisation
    {
        public static void Create_Graph(List<note_node> DTArray)
        {


            /*   int index;


               //String Temp_str = null;
               System.Windows.Forms.Form form = new System.Windows.Forms.Form();
               form.Size = new System.Drawing.Size(1000, 1000);
               form.WindowState = FormWindowState.Maximized;

               //create a viewer object
               GraphViewerGdi.GViewer viewer = new Microsoft.Glee.GraphViewerGdi.GViewer();

               //create a graph object
               Drawing.Graph graph = new Microsoft.Glee.Drawing.Graph("graph");



               foreach (note_node temp_node in DTArray)
               {
                   index = DTArray.IndexOf(temp_node);
                   String Parent_Note;
                   String Current_Note;


                   // Check if it's a route node 
                   if (temp_node.parent_node_index == null)
                   {
                       // Route node so skip

                   }
                   else
                   {


                       //Build the Node string values
                       Parent_Note = temp_node.parent_node_index.GetValueOrDefault().ToString() + "\r\n" + DTArray[temp_node.parent_node_index.GetValueOrDefault()].ToStringSmall();
                       //Current_Note = DTArray.IndexOf(temp_node).ToString() + "\r\n" + temp_node.ToStringSmall();

                       Current_Note =  temp_node.ToStringSmall();

                       // Not route node so add edge details
                       graph.AddEdge(Parent_Note, Current_Note);

                      if (temp_node.cost > 5)
                       {
                           graph.FindNode(Current_Note).Attr.Fillcolor = Microsoft.Glee.Drawing.Color.Red;

                       }
                      else if (temp_node.cost < 0)
                      {
                          graph.FindNode(Current_Note).Attr.Fillcolor = Microsoft.Glee.Drawing.Color.Green;
                      }

                   }

               }

               graph.CleanNodes();


               //bind the graph to the viewer
               viewer.Graph = graph;
               viewer.Size = new System.Drawing.Size(400, 400);


               //associate the viewer with the form
               form.SuspendLayout();
               viewer.Dock = System.Windows.Forms.DockStyle.Fill;
               form.Controls.Add(viewer);
               form.ResumeLayout();

               //show the form
               form.ShowDialog();
           }*/

        }
    }
}
