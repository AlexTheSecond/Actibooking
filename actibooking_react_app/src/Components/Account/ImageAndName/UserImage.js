const UserImage = (props) => {

  return (
          <img
            src="https://thumbs.dreamstime.com/b/default-avatar-profile-vector-user-profile-default-avatar-profile-vector-user-profile-profile-179376714.jpg"
            alt="Avatar"
            onClick={props.onClick}
          />
  );
};

export default UserImage;