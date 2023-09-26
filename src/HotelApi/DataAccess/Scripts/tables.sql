CREATE TABLE Introductions (
    IntroductionId INT PRIMARY KEY IDENTITY(1,1),
    Title VARCHAR(255),
    Description TEXT,
    DiscoverNowLink VARCHAR(255)
);

CREATE TABLE AboutUses (
    AboutUsId INT PRIMARY KEY IDENTITY(1,1),
    Title VARCHAR(255),
    Description TEXT,
    ReadNowLink VARCHAR(255),
    CoverImage VARCHAR(255)
);

CREATE TABLE Services (
    ServiceId INT PRIMARY KEY IDENTITY(1,1),
    Icon VARCHAR(100),
    Title VARCHAR(255),
    Description TEXT
);

CREATE TABLE Rooms (
    RoomId INT PRIMARY KEY IDENTITY(1,1),
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

CREATE TABLE TestimonialReviews (
    TestimonialReviewId INT PRIMARY KEY IDENTITY(1,1),
    Review TEXT,
    Author VARCHAR(100),
    AuthorId INT,
    Rate SMALLINT
);

CREATE TABLE NewsPosts (
    NewsPostId INT PRIMARY KEY IDENTITY(1,1),
    Title VARCHAR(255),
    Category VARCHAR(100),
    CoverImage VARCHAR(255),
    PostLink VARCHAR(255),
    PostDate INT
);

CREATE TABLE UserAccounts (
    UserAccountId INT PRIMARY KEY IDENTITY(1,1),
    Username VARCHAR(255),
    PasswordHash VARCHAR(100),
    CoverImage VARCHAR(255),
    PostLink VARCHAR(255),
    PostDate INT
);