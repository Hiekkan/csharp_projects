using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Jentzsch_Sudoku
{
    [Activity(Label = "GameActivity")]
    public class GameActivity : Activity
    {
        private LinearLayout shellBoard;
        private GridLayout gridBoard;
        private int width;
        private int height;
        private int cols;
        private int rows;
        private int tileCount;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_game);
            shellBoard = FindViewById<LinearLayout>(Resource.Id.shellBoard);
            gridBoard = FindViewById<GridLayout>(Resource.Id.gridBoard);

            width = gridBoard.MeasuredWidth;
            height = gridBoard.MeasuredHeight;
            cols = gridBoard.ColumnCount;
            rows = gridBoard.RowCount;
            tileCount = cols * rows;
        }
    }
}