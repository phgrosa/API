using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallAPI : MonoBehaviour
{

    public void GetCategoryByID()
    {
        Categories c = APIHelper.GetCategoryByID();

        print("Category ID = " + c.categoryID);
        print("Category Name = " + c.name);
        print("Category CreatedOn = " + c.createdOn);
        print("Category lastModified = " + c.lastModified);

    }

    public void GetAllCategories()
    {
        Categories[] c = APIHelper.GetAllCategories();

        foreach(Categories cat in c) { 
            print("Category ID = " + cat.categoryID);
            print("Category Name = " + cat.name);
            print("Category CreatedOn = " + cat.createdOn);
            print("Category lastModified = " + cat.lastModified);
        }
    }


    public void GetAllSubCategoryByCategoryID()
    {
        SubCategories[] sc = APIHelper.GetAllSubCategoryByCategoryID();

        foreach (SubCategories scat in sc)
        {
            print("subCategoryID = " + scat.subCategoryID);
            print("categoryID = " + scat.categoryID);
            print("name= " + scat.name);

            foreach (string tagId in scat.tagIDs)
            {
                print("tagID = " + tagId);
            }

            print("createdOn = " + scat.createdOn);
            print("lastModified = " + scat.lastModified);    
        }

    }

    public void GetSubCategoryBySubCategoryID()
    {
        SubCategories sc = APIHelper.GetSubCategoryBySubCategoryID();

        print("subCategoryID = " + sc.subCategoryID);
        print("categoryID = " + sc.categoryID);
        print("name= " + sc.name);

        foreach (string tagId in sc.tagIDs)
        {
            print("tagID = " + tagId);
        }

        print("createdOn = " + sc.createdOn);
        print("lastModified = " + sc.lastModified);

    }

    public void GetAllTags()
    {
        Tags[] t = APIHelper.GetAllTags();

        foreach (Tags tag in t)
        {
            print("tagID = " + tag.tagID);
            print("name = " + tag.name);
            foreach (string subCategoryIDs in tag.subCategoryIDs)
            {
                print("subCategoryIDs = " + subCategoryIDs);
            }

            print("createdOn = " + tag.createdOn);
            print("lastModified = " + tag.lastModified);
        }
    }


    public void GetTagByTagID()
    {
        Tags t = APIHelper.GetTagByTagID();

        print("tagID = " + t.tagID);
        print("name = " + t.name);
        foreach (string subCategoryIDs in t.subCategoryIDs)
        {
            print("subCategoryIDs = " + subCategoryIDs);
        }

        print("createdOn = " + t.createdOn);
        print("lastModified = " + t.lastModified);
    }

}
