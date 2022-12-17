import styles from "./LogOutButton.module.css";
import { useCookies } from "react-cookie";
import { Link } from "react-router-dom";

const LogOutButton = () =>{

    const [cookies, setCookies, removeCookie] = useCookies();


    const removeCookieHandler = () =>{
        removeCookie('token');
        setTimeout(()=>{
            window.location.reload();
        },100)
    }


    return(
        <Link to={"/"}>
            <button className={styles.button} onClick={removeCookieHandler}>Log out</button>
        </Link>
    )
}

export default LogOutButton;