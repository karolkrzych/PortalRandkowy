import { Photo } from './photo';

export interface User {
    /** Podstawowe informacje */
    id: number;
    username: string;
    gender: string;
    age: number;
    zodiacSign: string;
    created: Date;
    lastActive: Date;
    city: string;
    country: string;
    /** Zakładka Info */
    height: string;
    eyeColor: string;
    hairColour: string;
    martialStatus: string;
    education: string;
    profession: string;
    children: string;
    languages: string;
    /** Zakładka O mnie */
    motto: string;
    description: string;
    personality: string;
    lookingFor: string;
    /** Zakładka Pasje, zainteresowania */
    interests: string;
    freeTime: string;
    sport: string;
    movies: string;
    music: string;
    /** Zakładka Preferencje */
    iLike: string;
    idoNotLike: string;
    makesMeLaugh: string;
    itFeelsBestIn: string;
    friendsWouldDescribeMe: string;
    /** Zakładka Zdjęcia */
    photos: Photo[];
    photoUrl: string;
}
