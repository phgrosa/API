using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System.IO;

public static class APIHelper
{
    public static Categories GetCategoryByID()
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://dreamquizapidevelopment-env.eba-j2infqqm.us-east-1.elasticbeanstalk.com/api/categories/id/593b18f9-42b6-415e-b9d8-5df89f546ef6");
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        StreamReader reader = new StreamReader(response.GetResponseStream());
        string json = reader.ReadToEnd();
        return JsonUtility.FromJson<Categories>(json);
    }

    public static Categories[] GetAllCategories()
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://dreamquizapidevelopment-env.eba-j2infqqm.us-east-1.elasticbeanstalk.com/api/categories/all");
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        StreamReader reader = new StreamReader(response.GetResponseStream());
        string json = reader.ReadToEnd();
        Categories[] c = JsonHelper.getJsonArray<Categories>(json);
        return c;
    }

    public static SubCategories[] GetAllSubCategoryByCategoryID()
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://dreamquizapidevelopment-env.eba-j2infqqm.us-east-1.elasticbeanstalk.com/api/subCategories/category/593b18f9-42b6-415e-b9d8-5df89f546ef6");
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        StreamReader reader = new StreamReader(response.GetResponseStream());
        string json = reader.ReadToEnd();
        SubCategories[] sc = JsonHelper.getJsonArray<SubCategories>(json);
        return sc;
    }

    public static SubCategories GetSubCategoryBySubCategoryID()
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://dreamquizapidevelopment-env.eba-j2infqqm.us-east-1.elasticbeanstalk.com/api/subCategories/id/6aee33cf-8eb1-4a55-8472-ce38a8631920");
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        StreamReader reader = new StreamReader(response.GetResponseStream());
        string json = reader.ReadToEnd();
        return JsonUtility.FromJson<SubCategories>(json);
    }

    public static Tags[] GetAllTags()
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://dreamquizapidevelopment-env.eba-j2infqqm.us-east-1.elasticbeanstalk.com/api/tags/all");
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        StreamReader reader = new StreamReader(response.GetResponseStream());
        string json = reader.ReadToEnd();
        Tags[] t = JsonHelper.getJsonArray<Tags>(json);
        return t;
    }

    public static Tags GetTagByTagID()
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://dreamquizapidevelopment-env.eba-j2infqqm.us-east-1.elasticbeanstalk.com/api/tags/id/3c73bbb1-2868-4001-8e35-7b09fc2ea9a0");
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        StreamReader reader = new StreamReader(response.GetResponseStream());
        string json = reader.ReadToEnd();
        return JsonUtility.FromJson<Tags>(json);
    }
}
