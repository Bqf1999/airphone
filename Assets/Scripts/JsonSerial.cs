using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
public class JsonSerial <T>{

    public T user;
    public string filePath;

    public void saveJson() {

        if (!File.Exists(filePath))
        {
            File.Create(filePath);
        }
        string json = JsonUtility.ToJson(user, true);
        File.WriteAllText(filePath, json);
        Debug.Log("保存成功");
    }

    public T readJson() {

        if (!File.Exists(filePath))
        {
            Debug.Log("读取文件不存在");
            return user;
        }
        string json = File.ReadAllText(filePath);
        user = JsonUtility.FromJson<T>(json);
        return user;
    }
}
