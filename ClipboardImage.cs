using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

public static class ClipboardImage
{
    [DllImport("UnityClipboard")] private static extern bool Open();
    [DllImport("UnityClipboard")] private static extern int Width();
    [DllImport("UnityClipboard")] private static extern int Height();
    [DllImport("UnityClipboard")] private static extern int BitsPerPixel();
    [DllImport("UnityClipboard")] private static extern IntPtr Read();

    public static Texture2D Copy()
    {
        try
        {
            // no image in clipboard
            if (Open() == false)
                return null;
            
            var width  = Width();
            var height = Height();
            var step   = BitsPerPixel() / 8;
            var ptr    = Read();
            
            var tex = new Texture2D(width, height, GraphicsFormat.R8G8B8A8_SRGB, 0, TextureCreationFlags.None);
            
            var bytes = new byte[width * height * step];
            Marshal.Copy(ptr, bytes, 0, width * height * step);
            
            for (var y = 0; y < height; y++)
            for (var x = 0; x < width; x++)
            {
                var pos = (y * width + x) * 4;
                
                // read in bgra format
                var b = bytes[pos];
                var g = bytes[pos + 1];
                var r = bytes[pos + 2];
                var a = bytes[pos + 3];
                
                tex.SetPixel(x, height - y, new Color32(r, g, b, a));
            }

            tex.Apply();
            return tex;
        }
        catch (Exception e)
        {
            Debug.LogError($"Can't past image from clipboard {e}");
        }
        
        return null;
    }
}