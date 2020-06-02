using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcP.WHobjects
{
    public class Map
    {
        // ---------------------- Fields -----------------------
        private Tile[,] tilesArray;
        private int heightOfMap;
        private int lengthOfMap;
        // -------------------- Properties ---------------------
        public Tile[,] TilesArray { get { return tilesArray; } set { tilesArray = value; } }
        public int HeightOfMap { get { return heightOfMap; } set { heightOfMap = value; } }
        public int LengthOfMap { get { return lengthOfMap; } set { lengthOfMap = value; } }

        // -------------------- Constructors --------------------
        public Map()
        {

        }


        public bool checkRackList(int i, int j)
        {
            foreach (var item in iBlade.wh.GetRackList())
            {
                if (((item.Position.X -30) < i )&& ((item.Position.X + 50) > i )&& (item.Position.Y - 22  < j) && ((item.Position.Y + 50) > j))
                {
                    return false;
                }
            }
            return true;
        }
        #region Map creation
        /// <summary>
    
        /// </summary>
        public void CreateMap(string map, int x,int y)
        {
            TilesArray = new Tile[x,y];
            HeightOfMap = x;
            LengthOfMap = y;
            for(int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (checkRackList(i, j))
                    {
                        TilesArray[i, j] = new Tile(new Point(i, j));
                    }
                    else
                    {
                        TilesArray[i, j] = new TileRack(new Point(i, j));
                    }
                }
            }
        }
        #endregion



        private int[,] PopulateIntArray()
        {
            int[,] m = new int[tilesArray.GetLength(0), tilesArray.GetLength(1)];

            for (int i = 0; i < tilesArray.GetLength(0); i++)
            {
                for (int j = 0; j < tilesArray.GetLength(1); j++)
                {
                }
            }

            return m;
        }

        /// <summary>
        /// Helper method for reading a resource text file.
        /// </summary>
        /// <param name="resourceText"></param>
        /// <returns></returns>


        /// <summary>
        /// Gets a tile from a specified position.
        /// </summary>
        /// <param name="location">The location of the desired tile.</param>
        /// <returns>Will return null if no Tile could be found at the specified location, otherwise it will return the found Tile.</returns>
        public Tile GetTile(Point location)
        {
            for (int i = 0; i < tilesArray.GetLength(0); i++)
                for (int j = 0; j < tilesArray.GetLength(1); j++)
                    if (tilesArray[i, j].Location == location)
                        return tilesArray[i, j];

            return null;
        }
    }
}

