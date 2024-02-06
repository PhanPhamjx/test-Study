using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai_32_List : MonoBehaviour
{
    public class Student
    {
        // thuoc tinh
        public string HoTen;//{ get; set; } // private, public gioi han hoac mo rong pham vi truy cap
        // studen.HoTen = Get = lay gia tri , HoTen = "hdasd" = Set = dat gia tri
        public int Tuoi;//{ get; set; }
    }
    // khai bao 1 mang list co kieu du lieu la : Student
    List<Student> lstDanhsachStudent = new List<Student>();
    void Start()
    {
        Student student;
        student = new Student(); //  khoi tao gan bien 
        student.HoTen = "Martin Scorsese";
        student.Tuoi = 23;
        lstDanhsachStudent.Add(student);

        student = new Student();
        student.HoTen = "Quentin Tarantino";
        student.Tuoi = 36;
        lstDanhsachStudent.Add(student);

        student = new Student();
        student.HoTen = "Steven Spielberg";
        student.Tuoi = 19;
        lstDanhsachStudent.Add(student);
        for (int i = 0; i < lstDanhsachStudent.Count; i++)
        {
            Debug.Log("May em sinh vien ten la : " + lstDanhsachStudent[i].HoTen + "Nam nay co so tuoi la : " + lstDanhsachStudent[i].Tuoi);
        }
        foreach(Student giatri in lstDanhsachStudent)
        {
            Debug.Log("May em sinh vien ten la : " + giatri.HoTen + "Nam nay co so tuoi la : " + giatri.Tuoi );
        }
    }
}
