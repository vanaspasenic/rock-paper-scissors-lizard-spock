import { useEffect, useState } from "react";
import { OptionButton } from "../components/OptionButton/option-button";
import { httpClient } from "../services/HttpClient";
import { IChoice, IGameResult } from "../models/interfaces";
import { CustomModal } from "../components/SimpleModal/simple-modal";

export const Game = () => {
  const [options, setOptions] = useState<IChoice[]>([]);
  const [modalIsOpen, setModalIsOpen] = useState(false);
  const [modalContent, setModalContent] = useState<string>('');

  
  useEffect(() => {
    httpClient.httpGet<IChoice[]>('/Game/choices').then(setOptions);
  }, []);

  const playGame = (optionId: number) => {
      httpClient.httpPost<IGameResult>('/Game/play',  {choice_id: optionId} ).then((response) => {
        const formattedResult = formatGameResult(response);
        setModalContent(formattedResult);
        setModalIsOpen(true);
    });
  };

  const getRandomChoice = () => {
      httpClient.httpGet<IChoice>("/Game/randomChoice").then(result => {
              playGame(result.id);
      });
  };

  const formatGameResult = (response: IGameResult): string => {
    return 'You chose: ' + options.find(o => o.id === response.playerChoiceId)?.name + '\n' +
           'Computer chose: ' + options.find(o => o.id === response.computerChoiceId)?.name + '\n' +
           'Result: ' + response.result;
  };

  return (
    <div>
      <h1 className="title">rock paper scissors lizard spock</h1>
      <div  className="choice-container">
        {options.map((option) => (
          <OptionButton key={option.id} option={option} onClick={() => playGame(option.id)}/>
        ))}
      </div>

      <div className="random-choice-container">
        <p style={{ marginBottom: '0.5rem', fontStyle: 'italic', color: '#888' }}>
          Try to outsmart the computer in this game by using its own logic! (Or just trust your luck...)
        </p>
        <button
          title="Random choice"
          onClick={() => { getRandomChoice(); }}
        >
          Random Choice
        </button>
      </div>

      <CustomModal isOpen={modalIsOpen} onRequestClose={() => setModalIsOpen(false)} className="result-modal">
        <h2>Game Result</h2>
        <pre>{modalContent}</pre>
      </CustomModal>
    </div>
  );
};
