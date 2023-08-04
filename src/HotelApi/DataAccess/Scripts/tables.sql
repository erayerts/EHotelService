CREATE TABLE Introduction (
    IntroductionId INT PRIMARY KEY,
    Title VARCHAR(255),
    Description TEXT,
    DiscoverNowLink VARCHAR(255)
);

CREATE TABLE AboutUs (
    AboutUsId INT PRIMARY KEY,
    Title VARCHAR(255),
    Description TEXT,
    ReadNowLink VARCHAR(255),
    CoverImage VARCHAR(255)
);

CREATE TABLE Service (
    ServiceId INT PRIMARY KEY,
    Icon VARCHAR(100),
    Title VARCHAR(255),
    Description TEXT
);

CREATE TABLE Room (
    RoomId INT PRIMARY KEY,
    Price INT,
    RoomName VARCHAR(100),
    PriceCurrency VARCHAR(10),
    Size VARCHAR(20),
    Capacity VARCHAR(20),
    Bed VARCHAR(50),
    Services TEXT,
    CoverImage VARCHAR(255),
    MoreDetailsLink VARCHAR(255)
);

CREATE TABLE TestimonialReview (
    ReviewId INT PRIMARY KEY,
    Review TEXT,
    Author VARCHAR(100),
    Rate SMALLINT
);

CREATE TABLE NewsPost (
    PostId INT PRIMARY KEY,
    Title VARCHAR(255),
    Category VARCHAR(100),
    CoverImage VARCHAR(255),
    PostLink VARCHAR(255),
    PostDate DATE
);
