using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace FreeDraw
{
    // Helper methods used to set drawing settings
    public class DrawingSettings : MonoBehaviour
    {
        public static bool isCursorOverUI = false;
        public float Transparency = 1f;

        // Changing pen settings is easy as changing the static properties Drawable.Pen_Colour and Drawable.Pen_Width
        public void SetMarkerColour(Color new_color)
        {
            Drawable.Pen_Colour = new_color;
        }
        // new_width is radius in pixels
        public void SetMarkerWidth(int new_width)
        {
            Drawable.Pen_Width = new_width;
        }
        public void SetMarkerWidth(float new_width)
        {
            SetMarkerWidth((int)new_width);
        }

        public void SetTransparency(float amount)
        {
            Transparency = amount;
            Color c = Drawable.Pen_Colour;
            c.a = amount;
            Drawable.Pen_Colour = c;
        }

        private Color c;
        // Call these these to change the pen settings
        public void SetMarkerPurple()
        {
            c = new Color(122f / 255f, 35f / 255f, 130f / 255f);

            ColorDefaultEvent(0);
        }
        public void SetMarkerRed()
        {
            c = new Color(227f / 255f, 6f / 255f, 19f / 255f);

            ColorDefaultEvent(1);
        }
        public void SetMarkerYellow()
        {
            c = new Color(255f / 255f, 237f / 255f, 0f / 255f);

            ColorDefaultEvent(2);
        }
        public void SetMarkerOrange()
        {
            c = new Color(234f / 255f, 126f / 255f, 45f / 255f);

            ColorDefaultEvent(3);
        }
        public void SetMarkerDarkGreen()
        {
            c = new Color(0f / 255f, 133f / 255f, 62f / 255f);

            ColorDefaultEvent(4);
        }
        public void SetMarkerGreen()
        {
            c = new Color(104f / 255f, 179f / 255f, 46f / 255f);

            ColorDefaultEvent(5);
        }
        public void SetMarkerDarkBlue()
        {
            c = new Color(33f / 255f, 58f / 255f, 143f / 255f);

            ColorDefaultEvent(6);
        }
        public void SetMarkerBlue()
        {
            c = new Color(0f / 255f, 129f / 255f, 227f / 255f);

            ColorDefaultEvent(7);
        }
        public void SetMarkerLightPink()
        {
            c = new Color(241f / 255f, 147f / 255f, 189f / 255f);

            ColorDefaultEvent(8);
        }
        public void SetMarkerCreamColored()
        {
            c = new Color(255f / 255f, 223f / 255f, 196f / 255f);

            ColorDefaultEvent(9);
        }

        void ColorDefaultEvent(int outlineIndex)
        {
            foreach (Outline outL in ColorOutlines.Instance.outline)
            {
                outL.enabled = false;
            }
            ColorOutlines.Instance.outline[outlineIndex].enabled = true;

            Brush.Instance.gameObject.GetComponent<Image>().sprite = ColorOutlines.Instance.brushes[outlineIndex];
            //Standar options
            c.a = Transparency;
            SetMarkerColour(c);
            Drawable.drawable.SetPenBrush();
        }
       
     
        public void SetEraser()
        {
            SetMarkerColour(new Color(255f, 255f, 255f, 0f));
        }

        public void PartialSetEraser()
        {
            SetMarkerColour(new Color(255f, 255f, 255f, 0.5f));
        }
    }
}