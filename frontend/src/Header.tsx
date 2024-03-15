import logo from './BowlLogo.png';

function Header(props: any) {
  return (
    <header className="row navbar navbar-dark bg-dark">
      <div className="col-4">
        <img
          src={logo}
          className="logo"
          alt="logo"
          style={{ height: '200px' }}
        />
      </div>
      <div className="col subtitle">
        <h1 className="text-white">{props.title}</h1>
        <p className="text-white">
          {' '}
          {
            'Here is the personal contact info for the all of the local bowling teams'
          }
        </p>
      </div>
    </header>
  );
}

export default Header;
