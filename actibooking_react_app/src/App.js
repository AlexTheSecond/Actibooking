import jwtDecode from "jwt-decode";
import { Route, Routes } from "react-router-dom";
import FAQPage from "./Components/FAQPage/FAQPage";
import HomePage from "./Components/HomePage/HomePage";
import CookiesContext from "./Context/cookies-context";
import { CookiesProvider, useCookies } from "react-cookie";
import AccountPage from "./Components/Account/AccountPage";
import ListOfOrganizations from "./Components/Organization/ListOfOrganizations/ListOfOrganizations";
import SingleOrganizationPage from "../src/Components/Organization/SingleOrganizationPage/SingleOrganizationPage";
import EditOrganization from "./Components/EditOrganization/EditOrganization";
import Input from "./Components/DefaultModels/Input/Input";
import CalendarAuthorize from "./Components/Authorization/GoogleAthorization/CalendarAuthorize";

const App = () => {

  const [cookies, setCookies, removeCookie] = useCookies();
  console.log(process.env.REACT_APP_SECRET_KEY)

  const GetCookie = (cookieName) => {
    return cookies[cookieName];
  };

  const SetCookie = (
    cookieName,
    cookieValue,
    cookiePath = null,
    options = null
  ) => {
    setCookies(cookieName, cookieValue, { path: cookiePath }, options);
  };

  const RemoveCookie = (cookieName) => {
    removeCookie(cookieName);
  };

  const DecodeToken = (token) => {
    return jwtDecode(token);
  };

  return (
    <CookiesProvider>
      <CookiesContext.Provider
        value={{
          GetCookie,
          SetCookie,
          RemoveCookie,
          DecodeToken,
        }}
      >
        <Routes>
          <Route path="/Magic" element={<CalendarAuthorize/>}/>
          <Route path="/" element={<HomePage/>}/>
          <Route path="/Organizations" element={<ListOfOrganizations/>}/>
          <Route path="/Organizations/:id" element={<SingleOrganizationPage/>}/>
          <Route path="/Edit/Organization/:id" element={<EditOrganization/>}/>
          <Route path="/Account/:id" element={<AccountPage/>}/>
          <Route path="/FAQ" element={<FAQPage/>}/>
          <Route path="/Input" element={<Input id={1} type={'text'} value={"some value"} label={"My Label"} onChange={e=>{console.log(e.target.value)}}/>}/>
        </Routes>
      </CookiesContext.Provider>
    </CookiesProvider>
  );
};

export default App;
