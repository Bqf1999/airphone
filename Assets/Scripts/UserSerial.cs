using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

[Serializable]
public class UserSerial
{
    public string account;
    public string password;

    public UserSerial(string id,string pwd) {
        this.account = id;
        this.password = pwd;
    }
    public void  setAccountId(string id) {
        this.account = id;
    }
    public void setPassword(string pwd) {
        this.password = pwd;
    }
    public string getAccountId() {
        return account;
    }
    public string getPassword() {
        return password;
    }

}