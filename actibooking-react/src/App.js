import Home from "./Home";
import React, {useState} from "react";
import {Route, Routes} from "react-router-dom";
import NaviBar from "./components/navibar/Navibar";
import Organization from "./components/Organization/Organization";
import Organizations from "./components/Organization/Organizations";
import CreateOrganization from "./components/Organization/CreateOrganization";
import BaseWrapper from "./components/CardWrappers/BaseWrapper";
import MainLogo from "./components/Logo/MainLogo";
import LogIn from "./components/Authentication/LogIn";
import SignUp from "./components/Authentication/SignUp"

const App = () => {
  let userStatus = false;
  let token = "";

  const setToken = data =>{
    token = data;
  }
  const authorization = user => {
    userStatus = {"Exp": user.exp, "Role": user["http://schemas.microsoft.com/ws/2008/06/identity/claims/role"], "Email": user["http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name"]};
  }

  return (
    <div>
      <MainLogo/>
      <BaseWrapper>
      <NaviBar userStatus={userStatus}></NaviBar>
      </BaseWrapper>  
      <Routes>
        <Route path="/" element={<Home userStatus = {userStatus}/>}/>
        <Route path="/Organizations/:id" element={<BaseWrapper><Organization/></BaseWrapper>}/>
        <Route path="/Organizations" element={<BaseWrapper><Organizations userStatus = {userStatus}/></BaseWrapper>}/>
        <Route path="/Organization/Create" element={<CreateOrganization userStatus = {true}/>}/>
        <Route path="/LogIn" element={<BaseWrapper><LogIn userStatus = {userStatus} authorization = {authorization} setToken={setToken}/></BaseWrapper>}/>
        <Route path="/SignUp" element={<BaseWrapper><SignUp/></BaseWrapper>}/>
      </Routes>
    </div>
  );
}

export default App;
