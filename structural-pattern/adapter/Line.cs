using System;

namespace adapter{

    public class Line{
        public Point Start, End;

        public Line(Point start, Point end){

            if(start == null){
                throw new ArgumentException(paramName : nameof(start));
            }

            if(end == null){
                throw new ArgumentException(paramName : nameof(end));
            }

            Start = start;
            End = end;
        }
    }

}