<p align="center"><img src="http://aparanblog.do.am/fixed.png"></p></br><br>
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
private void Draw_Graph_Click(object sender, RoutedEventArgs e)
{
    HttpClient client = new HttpClient();
    JavaScriptSerializer jss = new JavaScriptSerializer();
    string url = string.Format("http://localhost:53901/api/plot");
    client.GetAsync(url).ContinueWith(resurse =>
    {
        HttpResponseMessage message = client.GetAsync(url).Result;
        string responseText = message.Content.ReadAsStringAsync().Result;
        List<Point> list = jss.Deserialize<List<Point>>(responseText);

        Dispatcher.BeginInvoke(DispatcherPriority.Normal,
                   (Action)(() =>
                   {
                       foreach (var item in list)
                       {
                           polyline.Points.Add(CorrespondingPoint(new Point(item.X, item.Y)));
                       }
                       canvas.Children.Add(polyline);
                   }));
    }



    );
}


```


<h4>Author <a href="https://github.com/tigranv">Tigran Vardanyan</a><h4>
