using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColorAndBalls.Models;

namespace ColorAndBalls.Repository
{
    public class BallRepository : IRepository<Ball>
    {
        List<Ball> balls = new List<Ball>();
        public int Delete(int id)
        {
            Ball ball = GetById(id);
            if (ball != null)
            {
                balls.Remove(ball);
                return 1;
            }
            return 0;
        }

        public List<Ball> GetAll()
        {
            return balls;
        }

        public Ball GetById(int id)
        {
            for (int i = 0; i <balls.Count; i++)
            {
                if (balls[i].Id == id)
                {
                    return balls[i];
                }
            }
            return null;
        }

        public int Insert(Ball obj)
        {
            balls.Add(obj);

            return 1;
        }

        public int Update(Ball obj)
        {
            Ball ball = new Ball();
            if (ball != null)
            {
                ball.Id = obj.Id;
                ball.size = obj.size;
                ball.color= obj.color;
                ball.throws = obj.throws;
                return 1;
            }
            return 0;
        }


    }
}
