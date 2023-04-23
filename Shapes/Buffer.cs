using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Buffer
    {
        public List<PolygonData> buffer { get; set; }
        int currentState;

        public Buffer()
        {
            buffer = new List<PolygonData>();
            currentState = -1;
        }

        public int CurrentState => currentState;
        public void SaveCurrentState(PolygonData state)
        {
            // start debug
            //Debug.WriteLine($"\n++currentState = {currentState + 1}, buffer.Count - 1 = {buffer.Count - 1}");
            //foreach (PolygonData data in buffer)
            //    Debug.WriteLine(data.Shapes.Count);
            //Debug.WriteLine("");
            // end debug
            if (++currentState <= buffer.Count - 1)
            {
                // start debug
                //Debug.WriteLine($"buffer[currentRange].Count = {buffer[currentState].Shapes.Count}");
                // end debug

                buffer.RemoveRange(currentState, buffer.Count - currentState);

                // start debug
                //foreach (PolygonData data in buffer)
                //    Debug.WriteLine(data.Shapes.Count);
                // end debug
            }

            buffer.Add(state);
            
            if (buffer.Count > 50)
            {
                buffer.RemoveAt(0);
                currentState--;
            }


            // start debug
            //Debug.WriteLine($"\nsave state\n" +
            //    $"buffer len: {buffer.Count}\n" +
            //    $"currentState: {currentState}");
            // end debug
        }

        public PolygonData RevertToPreviousState()
        {
            //start debug
            //foreach (PolygonData data in buffer)
            //    Debug.WriteLine(data.Shapes.Count);
            //Debug.WriteLine("");
            // end debug

            if (currentState - 1 >= 0)
                currentState--;

            //start debug
            //Debug.WriteLine($"prev\n" +
            //    $"buffer len: {buffer.Count}\n" +
            //    $"currentState: {currentState}\n" +
            //    $"currentStateLen: {buffer[currentState].Shapes.Count}");
            // end debug

            return buffer[currentState];
        }

        public PolygonData RevertToNextState()
        {
            if (currentState < buffer.Count - 1)
                currentState++;

            // start debug
            //Debug.WriteLine($"\nnext\n" +
            //    $"buffer len: {buffer.Count}\n" +
            //    $"currentState: {currentState}\n" +
            //    $"currentStateLen: {buffer[currentState].Shapes.Count}");
            // end debug

            return buffer[currentState];
        }

        public void Clear()
        {
            buffer.Clear();
            currentState = -1;
        }
    }
}
