export interface IChoice {
    id: number;
    name: string;
}

export interface IGameResult {
    playerChoiceId: number;
    computerChoiceId: number;
    result: string;
}