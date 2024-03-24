using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using CookComputing.XmlRpc;


public class MatrixService : IMatrixServiceServer
{
    public int[][] matrixHandle(int[][] m)
    {
        //поиск индексов минимального элемента
        int iMin=0, jMin=0;
        for(int i=0; i < m.Length; i++)
        {
            for(int j=0;j<m[i].Length; j++)
            {
                if (m[i][j] < m[iMin][jMin])
                {
                    iMin = i;
                    jMin = j;
                }
            }
        }

        //обнуление диагонали
        for(int i=0; i<m.Length; i++)
        {
            if((jMin - (iMin - i)>=0)&&(jMin - (iMin - i)<m[i].Length))
                m[i][jMin - (iMin - i)]=0;
        }

        //возведение в квадрат элементов ниже диагонали
        for(int i=0; i < m.Length; i++)
        {
            for(int j=0; j < m.Length; j++)
            {
                if ((j < jMin - (iMin - i)) && (jMin - (iMin - i) >= 0))
                    m[i][j] *= m[i][j];
            }
        }
           
        return m;
    }


    public int[][] getMatrixFromXml(XmlDocument xml)
    {
        int[][] matrix;

        var elements = xml.GetElementsByTagName("i4");
        int size = (int)Math.Sqrt(elements.Count);
        int now = 0;
        matrix = new int[size][];
        for (int i = 0; i < size; i++)
        {
            matrix[i] = new int[size];
            for (int j = 0; j < size; j++)
            {
                matrix[i][j] = int.Parse(elements[now].InnerText);
                now++;
            }
        }

        return matrix;
    }

    public string getResponseBody(int[][] matrix)
    {
        int size = matrix.Length;
        var docAns = new XDocument();
        var array = new XElement("array");
        docAns.Add(array);
        var data = new XElement("data");
        array.Add(data);
        for (int i = 0; i < size; i++)
        {
            var value = new XElement("value");
            data.Add(value);
            var array2 = new XElement("array");
            value.Add(array2);
            var data2 = new XElement("data");
            array2.Add(data2);

            for (int j = 0; j < size; j++)
            {
                var value2 = new XElement("value");
                data2.Add(value2);
                var iTag = new XElement("i4", matrix[i][j]);
                value2.Add(iTag);
            }
        }

        string ans =
            "<?xml version = '1.0'?>" +
            "<methodResponse>" +
                "<params>" +
                    "<param>" +
                        "<value>" + docAns.ToString() + "</value>" +
                    "</param>" +
                "</params>" +
            "</methodResponse>";

        return ans;
    }
}
