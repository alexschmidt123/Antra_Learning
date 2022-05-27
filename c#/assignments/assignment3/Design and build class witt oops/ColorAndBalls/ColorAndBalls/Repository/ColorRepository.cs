using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColorAndBalls.Models;

namespace ColorAndBalls.Repository
{
    public class ColorRepository : IRepository<Color>
    {
        List<Color> colors = new List<Color>();
        public int Delete(int id)
        {
            Color color = GetById(id);
            if (color != null)
            {
                colors.Remove(color);
                return 1;
            }
            return 0;
        }

        public List<Color> GetAll()
        {
            return colors;
        }

        public Color GetById(int id)
        {
            for (int i = 0; i < colors.Count; i++)
            {
                if (colors[i].Id == id)
                {
                    return colors[i];
                }
            }
            return null;
        }

        public int Insert(Color obj)
        {
            colors.Add(obj);

            return 1;
        }

        public int Update(Color obj)
        {
            Color color = new Color();
            if (color != null)
            {
                color.Id = obj.Id;
                color.red = obj.red;
                color.green = obj.green;
                color.blue = obj.blue;
                color.alpha = obj.alpha;
                return 1;
            }
            return 0;
        }


    }
}
