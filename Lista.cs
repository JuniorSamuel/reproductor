using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace reproductor
{

    class Lista
    {
        private String reproducir;
        private String direcction;
        private ArrayList list;
        int sel = 0;
        public Lista()
        {
            this.reproducir = "";
            this.direcction = "";
            this.list = new ArrayList();
          
        }

        public String reproduciendo()
        {
            if (list.Count > -1 && list.Count >= sel)
            {
                reproducir = (String) list[sel];
            }
            return reproducir;
        }

        public void siguiente()
        {
            if (sel >= list.Count)
            {
                sel = 0;
            }
            else
            {
                sel += 1;
            }
        }

        public void atras()
        {
            if (sel != 0)
            {
                sel -= 1;
            }
            else
            {
                sel = list.Count;
            }
        }
        public void setSelector(int index)
        {
            sel = index;
        }

        public int getSelector()
        {
            return sel;
        }

        public void setReproducir(String cancion)
        {
            reproducir = cancion;
        }

        public void setDirecction(String url)
        {
            direcction = url;
        }

        public void setList(ArrayList list)
        {
            this.list = list;
        }

        public void addCancion(String cancion)
        {
            list.Add(cancion);
        }

        public void addCancion(String[] cancion)
        {
            foreach(String ar in cancion){
                Console.WriteLine(ar);
                list.Add(ar);
            }
        }
        public String getReproducir()
        {
            reproduciendo();
            return reproducir;
        }

        public ArrayList getList()
        {
            return list;
        }

        public String getDirecction()
        {
            return direcction;
        }

        public void limpiar()
        {
            list.Clear();
        }
    }

}
