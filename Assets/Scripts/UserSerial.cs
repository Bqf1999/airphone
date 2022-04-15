using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

[Serializable]
public class UserSerial
{
    public string accountId;
    public string password;


    public UserSerial() { }
    public UserSerial(string id,string pwd) {
        this.accountId = id;
        this.password = pwd;
    }
    public void  setAccountId(string id) {
        this.accountId = id;
    }
    public void setPassword(string pwd) {
        this.password = pwd;
    }
    public string getAccountId() {
        return accountId;
    }
    public string getPassword() {
        return password;
    }

}