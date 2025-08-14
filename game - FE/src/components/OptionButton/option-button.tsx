import React from "react";
import { IChoice } from "../../models/interfaces";
import "./option-button.scss";

interface OptionButtonProps {
  option: IChoice;
  onClick: () => void;
}

export const OptionButton: React.FC<OptionButtonProps> = ({ option, onClick }) => {
  const emojiMap: Record<string, string> = {
    rock: '🪨',
    paper: '📄',
    scissors: '✂️',
    lizard: '🦎',
    spock: '🖖' 
   };

  const emoji = emojiMap[option.name] || '❓';
  return (
    <button onClick={onClick}>
      <span>{emoji}</span>
    </button>
  );
};