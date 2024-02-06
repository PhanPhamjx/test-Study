using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovieType
{
    public static int Count = 0;
    public string MovieName;
    public string Director; // 
    private float BoxOffice; // Tinh Dong Goi: muon che giau thong tin hoac gioi han truy cap ve doanh thu phim = su dung Get,Set de lay private
    public bool Rating;
    public MovieType()
    {

    }
    public void ShowInfo() // hien thi
    {
        Count++;
        string raTing = "asdasd";
        if (Rating == true)
        {
            raTing = "> 18+";
        }
        else
        {
            raTing = "< = 18+";
        }
        Debug.Log("Arts of Movies: " + MovieName + "--->" + Director + "--->" + BoxOffice + "--->" + raTing);
    }
    public void SetInfo(string MovieName, string Director, float BoxOffice, bool Rating)
    {
        Count++;
        this.MovieName = MovieName;
        this.Director = Director;
        this.BoxOffice = BoxOffice;
        this.Rating = Rating;
    }
    public void GetInfo()
    {

        string rating = "";
        if (Rating == true)
        {
            rating = " > 18+ ";
        }
        else
        {
            rating = " <= 18+ ";
        }
        Debug.Log("Arts of Movies: " + MovieName + "--->" + Director + "--->" + BoxOffice + "--->" + rating);
    }
    public float boxOffice // thuoc tinh
    {
        get
        {
            return BoxOffice;
        }
        set
        {
            if (value >= 0 && value <= 220)
            {
                BoxOffice = value;
            }
        }
    }
    public MovieType(string MovieName, string Director, float BoxOffice, bool Rating)
    {
        this.MovieName = MovieName;
        this.Director = Director;
        this.BoxOffice = BoxOffice;
        this.Rating = Rating;
    }
}
public class Horror : MovieType // lop con cua MovieType
{
    public Horror() : base("aa", "bb", 112, true)// goi qua base
    {

    }
    public virtual void HienThi() //
    {

        Debug.Log(" its Horror Base time");
    }
}
public class SlowBurn : Horror // lop con cua Horror, chau cua Movetype
{
    public override void HienThi()
    {
        Debug.Log("its SlowBurn time");
    }
}
public class Cosmic : Horror
{
    public override void HienThi()
    {
        Debug.Log("its Cosmic Time: ");

    }
}
public class Action : MovieType
{
    public Action()
    {
        Debug.Log("Action time!");
    }
}
public class Class_KeThua_Movies : MonoBehaviour
{
    // khai bao lop con cua Horror. chau cua MoviesType
    Horror hr1 = new Horror();
    Horror hr2 = new SlowBurn();
    Horror hr3 = new Cosmic();
    void Start()
    {
        MovieType mv1 = new MovieType();
        mv1.SetInfo("Batman", "Tim Burton", 134, true);
        mv1.boxOffice = 211; // gan gia tri sau khi Get va Set
        mv1.GetInfo();
        SlowBurn mv2 = new SlowBurn();
        mv2.SetInfo("Mid Summer", "Aria Aster", 20, true);
        mv2.GetInfo();

        hr1.HienThi();
        hr2.HienThi();
        hr3.HienThi();

        SlowBurn hor1 = new SlowBurn();
        hor1.MovieName = "Evil Dead";
        hor1.Director = "Sam Raimi";
        hor1.boxOffice = 54;
        hor1.Rating = false;
        bool isMovie = hor1 is MovieType; // heck co trong Class hay khong
        Debug.Log("Check hor1 co trong Class MovieType hay khong:" + isMovie);
        bool ishorror = hor1 is Horror;   // check co trong Class hay khong
        Debug.Log("Check hor1 co trong Class Horror hay khong:" + ishorror);
        hor1.ShowInfo();
        Debug.Log("Tong so Movies la : " + MovieType.Count);

    }

}
