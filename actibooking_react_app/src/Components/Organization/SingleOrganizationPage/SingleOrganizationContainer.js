import DescriptionBody from "./DescriptionBody/DescriptionBody";
import OrganizationNavbar from "./OrganizationNavbar/OrganizationNabar";
import styles from "./SingleOrganizationContainer.module.css";
import { useState } from "react";
import TrainersBody from "./TrainersBody/TrainersBody";
import AdressBody from "./AdressBody/AdressBody";
import CoursesBody from "./CoursesBody/CoursesBody";
import GalleriesBody from "./GalleriesBody/GalleriesBody";
import Button from "../../DefaultModels/Buttons/Button";
const SingleOrganizationContainer = (params) => {
  const [container, setContainer] = useState({
    description: false,
    adress: false,
    courses: true,
    trainers: false,
    gallery:false,
  });

  const ChangeContainer = (containerName) => {
    ClearContainer();
    if (containerName === "description") {
      setContainer((prevState) => {
        return { ...prevState, description: containerName };
      });
    } else if (containerName === "adress") {
      setContainer((prevState) => {
        return { ...prevState, adress: containerName };
      });
    } else if (containerName === "courses") {
      setContainer((prevState) => {
        return { ...prevState, courses: containerName };
      });
    } else if (containerName === "trainers") {
      setContainer((prevState) => {
        return { ...prevState, trainers: containerName };
      });
    }
    else if (containerName === "gallery") {
      setContainer((prevState) => {
        return { ...prevState, gallery: containerName };
      });
    }
  };

  const ClearContainer = () => {
    setContainer({
      description: false,
      adress: false,
      courses: false,
      trainers: false,
      gallery:false,
    });
  };

  const organization = params.organization;
  console.log(organization);
  return (
    <div className={styles.singleOrganizationContainer}>
      <div className={styles.mainDataContainer}>
        <div className={styles.imageContainer}>
          <img
            alt="organization image"
            className={styles.image}
            src={organization.logoUrl}
          />
        </div>
        <div className={styles.mainInfoContainer}>
          <div className={styles.nameContainer}>{organization.name}</div>
          <div className={styles.addressContainer}>{organization.addresses.zipcode} {organization.addresses.city} </div>
          <div className={styles.addressContainer}>{organization.addresses.street} {organization.addresses.streetNumber} </div>
          <Button value="Edit" href={`/Edit/Organization/${organization.id}`}></Button>
        </div>
      </div>
      <OrganizationNavbar changeContainer={ChangeContainer} />
      {container.description && (
        <DescriptionBody organizationDescription={organization.description} />
      )}
      {container.adress && (
        <AdressBody organizationAdress={organization.addresses} />
      )}
      {container.courses && (
        <CoursesBody organizationDescription={organization.courses} />
      )}
      {container.trainers && (
        <TrainersBody organizationDescription={organization.trainers} />
      )}
      {container.gallery && (
        <GalleriesBody id={organization.id} organizationDescription={organization.gallery} />
      )}
    </div>
  );
};

export default SingleOrganizationContainer;
