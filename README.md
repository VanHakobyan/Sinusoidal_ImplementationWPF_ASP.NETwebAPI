<p align="center"><img src="http://aparanblog.do.am/fixed.png"></p></br><br>


<h4>Author <a href="https://github.com/tigranv">Tigran Vardanyan</a><h4>

```C#
private Point CorrespondingPoint(Point pt)
{
    double xmin = 0;
    double xmax = 6.5;
    double ymin = -1.1;
    double ymax = 1.1;

    var result = new Point
    {
        X = (pt.X - xmin) * canvas.Width / (xmax - xmin),
        Y = canvas.Height - (pt.Y - ymin) * canvas.Height / (ymax - ymin)
    };
    return result;
}
```
