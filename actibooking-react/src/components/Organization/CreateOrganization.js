import React, {useState} from "react";
import "./CreateOrganization.css";
import { useNavigate } from "react-router-dom";
import BaseWrapper from "../CardWrappers/BaseWrapper";
import NewOrganizationForm from "./NewOrganizationForm";
import PostDataHandler from "../../data/PostDataHandler";
import ConstantsOrganizations from "../../constants/Constants";

const CreateOrganization = props => {


    const [warning, setWarning] = useState(false)
    const [response, setResponse] = useState("Create your organization !")


    let navigate = useNavigate();
    const changeRoute = () =>{
        let path = `/`;
        navigate(path);
    }

    const postOrganizationHandler = organization =>{
        PostDataHandler(ConstantsOrganizations.API_URL_CREATE_ORGANIZATION, organization, receiveResponseStatus);
    }

    const creationSucceed = () => {
        setWarning(true);
        setResponse("Success !");
    }
    const creationFailed = () => {
        setWarning(false);
        setResponse(" Server not responding properly ... ");
    }

    const receiveResponseStatus = status => {
        if (status !== true) {
            creationFailed()}
        else creationSucceed();
    }

    if (props.userStatus !== true) changeRoute();
    else return (
        <BaseWrapper>
            <div className="page-title"><strong>{response}</strong></div>
            <NewOrganizationForm postOrganization = {postOrganizationHandler} warning = {warning} setresponse={setResponse}/>
        </BaseWrapper>
    )
}
export default CreateOrganization;